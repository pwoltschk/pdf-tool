using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PdfTool.Processors;
using PdfTool.Processors.Adapter;
using System.IO;

namespace PdfTool.Tests
{
    [TestClass]
    public class MergeProcessorTests
    {
        private Mock<IPdfReader> _pdfReaderMock;
        private Mock<IPdfWriter> _pdfWriterMock;
        private MergeProcessor _mergeProcessor;

        [TestInitialize]
        public void TestInitialize()
        {
            _pdfReaderMock = new Mock<IPdfReader>();
            _pdfWriterMock = new Mock<IPdfWriter>();
            _mergeProcessor = new MergeProcessor(_pdfReaderMock.Object, _pdfWriterMock.Object);
        }

        [TestMethod]
        public void Merge_CallsExpectedMethods()
        {
            // Arrange
            var pdfPath = new string[] { "page1.pdf", "page2.pdf"};
            var pdfDocumentMock = new Mock<IPdfDocument>();
            var pdfPageMock = new Mock<IPdfPage>();

            _pdfReaderMock.Setup(x => x.GetPdfDocument(It.IsAny<string>())).Returns(pdfDocumentMock.Object);
            _pdfWriterMock.Setup(x => x.GetPdfDocument(It.IsAny<string>())).Returns(pdfDocumentMock.Object);
            pdfDocumentMock.Setup(x => x.GetNumberOfPages()).Returns(1);
            pdfDocumentMock.Setup(x => x.GetPage(It.IsAny<int>())).Returns(pdfPageMock.Object);

            // Act
            _mergeProcessor.Merge(pdfPath);

            // Assert
            _pdfReaderMock.Verify(x => x.GetPdfDocument(It.IsAny<string>()), Times.Exactly(2));
            _pdfWriterMock.Verify(x => x.GetPdfDocument(It.IsAny<string>()), Times.Exactly(1));
            pdfDocumentMock.Verify(x => x.GetNumberOfPages(), Times.Exactly(2));
            pdfDocumentMock.Verify(x => x.GetPage(It.IsAny<int>()), Times.Exactly(2));
        }
    }
}