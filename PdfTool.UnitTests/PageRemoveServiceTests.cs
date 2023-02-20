using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PdfTool.Processors.Adapter;
using PdfTool.Services;
using System.Linq;
using System.Threading.Tasks;

namespace PdfTool.UnitTests
{

    [TestClass]
    public class PageRemoveServiceTests
    {
        private Mock<IPdfReader> _mockPdfReader;
        private Mock<IPdfWriter> _mockPdfWriter;
        private Mock<IPdfDocument> _mockInputPdfDocument;
        private Mock<IPdfDocument> _mockOutputPdfDocument;
        private PageRemoveService _service;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockPdfReader = new Mock<IPdfReader>();
            _mockPdfWriter = new Mock<IPdfWriter>();
            _mockInputPdfDocument = new Mock<IPdfDocument>();
            _mockOutputPdfDocument = new Mock<IPdfDocument>();
            _service = new PageRemoveService(_mockPdfReader.Object, _mockPdfWriter.Object);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 5)]
        [DataRow(new int[] { 2, 3, 4 }, 6)]
        [DataRow(new int[] { 1, 3, 5 }, 7)]
        public async Task RemovePages_RemovesCorrectPages(int[] pagesToRemove, int numberOfPages)
        {
            // Arrange
            string inputPdfPath = "input.pdf";
            string outputPdfPath = "output.pdf";

            _mockPdfReader.Setup(r => r.Read(inputPdfPath)).Returns(_mockInputPdfDocument.Object);
            _mockPdfWriter.Setup(w => w.Write(outputPdfPath, false)).Returns(_mockOutputPdfDocument.Object);
            _mockInputPdfDocument.Setup(d => d.GetNumberOfPages()).Returns(numberOfPages);
            _mockInputPdfDocument.Setup(d => d.GetPage(It.Is<int>(page => !pagesToRemove.Contains(page)))).Returns(Mock.Of<IPdfPage>());

            // Act
            await _service.RemovePages(inputPdfPath, outputPdfPath, pagesToRemove);

            // Assert
            _mockInputPdfDocument.Verify(d => d.GetPage(It.Is<int>(page => !pagesToRemove.Contains(page))), Times.Exactly(numberOfPages - pagesToRemove.Length));
            _mockOutputPdfDocument.Verify(d => d.AddNewPage(It.IsAny<IPdfPage>()), Times.Exactly(numberOfPages - pagesToRemove.Length));
        }
    }


}
