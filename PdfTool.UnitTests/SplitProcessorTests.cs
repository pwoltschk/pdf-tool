using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PdfTool.Processors.Adapter;
using System.Threading.Tasks;

namespace PdfTool.UnitTests
{
    [TestClass]
    public class SplitProcessorTests
    {
        private Mock<IPath> _mockPath;
        private Mock<IDirectory> _mockDirectory;
        private Mock<IPdfReader> _mockPdfReader;
        private Mock<IPdfWriter> _mockPdfWriter;
        private SplitProcessor _splitProcessor;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockPath = new Mock<IPath>();
            _mockDirectory = new Mock<IDirectory>();
            _mockPdfReader = new Mock<IPdfReader>();
            _mockPdfWriter = new Mock<IPdfWriter>();

            _splitProcessor = new SplitProcessor(_mockPath.Object, _mockDirectory.Object, _mockPdfReader.Object, _mockPdfWriter.Object);
        }

        [TestMethod]
        public async Task GivenSplitProcessor_WhenSplit_ThenCreatesDirectoryAndSplitsPdf()
        {
            // Arrange
            var fullPath = "fullPath.pdf";
            var directory = "directory";
            var filename = "filename";
            var outputDirectory = "outputDirectory";
            var outputPdfPath = "outputPdfPath.pdf";
            var numberOfPages = 5;

            _mockPath.Setup(p => p.GetDirectoryName(fullPath)).Returns(directory);
            _mockPath.Setup(p => p.GetFileNameWithoutExtension(fullPath)).Returns(filename);
            _mockPath.Setup(p => p.Combine(directory, filename)).Returns(outputDirectory);
            _mockPath.Setup(p => p.Combine(outputDirectory, It.IsAny<string>())).Returns(outputPdfPath);

            var mockPdfDocument = new Mock<IPdfDocument>();
            mockPdfDocument.Setup(d => d.GetNumberOfPages()).Returns(numberOfPages);

            _mockPdfReader.Setup(r => r.GetPdfDocument(fullPath)).Returns(mockPdfDocument.Object);

            var mockOutputDocument = new Mock<IPdfDocument>();
            _mockPdfWriter.Setup(w => w.GetPdfDocument(outputPdfPath, false)).Returns(mockOutputDocument.Object);

            // Act
            await _splitProcessor.Split(fullPath);

            // Assert
            _mockDirectory.Verify(d => d.CreateDirectory(outputDirectory), Times.Once);
            _mockPdfReader.Verify(r => r.GetPdfDocument(fullPath), Times.Once);
            _mockPdfWriter.Verify(w => w.GetPdfDocument(outputPdfPath, false), Times.Exactly(numberOfPages));
            mockPdfDocument.Verify(d => d.CopyPagesTo(It.IsAny<int>(), It.IsAny<int>(), mockOutputDocument.Object), Times.Exactly(numberOfPages));
        }
    }
}
