using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PdfTool.Processors.Adapter;
using System.Threading.Tasks;
using PdfTool.Processors;

namespace PdfTool.UnitTests
{
    [TestClass]
    public class SplitProcessorTests
    {
        private Mock<IDirectory> _mockDirectory;
        private Mock<IPdfReader> _mockPdfReader;
        private Mock<IPdfWriter> _mockPdfWriter;
        private SplitProcessor _splitProcessor;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockDirectory = new Mock<IDirectory>();
            _mockPdfReader = new Mock<IPdfReader>();
            _mockPdfWriter = new Mock<IPdfWriter>();

            _splitProcessor = new SplitProcessor(_mockDirectory.Object, _mockPdfReader.Object, _mockPdfWriter.Object);
        }

        [TestMethod]
        public async Task GivenSplitProcessor_WhenSplit_ThenCreatesDirectoryAndSplitsPdf()
        {
            // Arrange
            var fullPath = "outputDirectory\\fullPath.pdf";
            var outputDirectory = "outputDirectory\\fullPath";
            var numberOfPages = 5;


            var mockPdfDocument = new Mock<IPdfDocument>();
            mockPdfDocument.Setup(d => d.GetNumberOfPages()).Returns(numberOfPages);

            _mockPdfReader.Setup(r => r.Read(fullPath)).Returns(mockPdfDocument.Object);

            var mockOutputDocument = new Mock<IPdfDocument>();

            // Act
            await _splitProcessor.Split(fullPath);

            // Assert
            _mockDirectory.Verify(d => d.CreateDirectory(outputDirectory), Times.Once);
            _mockPdfReader.Verify(r => r.Read(fullPath), Times.Once);
            mockPdfDocument.Verify(d => d.CopyPagesTo(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<IPdfDocument>()), Times.Exactly(numberOfPages));
        }
    }
}
