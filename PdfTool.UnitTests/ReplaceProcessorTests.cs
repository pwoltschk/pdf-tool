using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PdfTool.Processors;
using PdfTool.Processors.Adapter;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PdfTool.UnitTests
{
    [TestClass]
    public class ReplaceProcessorTests
    {
        private Mock<IPdfReader> _pdfReaderMock;
        private Mock<IPdfWriter> _pdfWriterMock;
        private ReplaceProcessor _replaceProcessor;

        [TestInitialize]
        public void TestInitialize()
        {
            _pdfReaderMock = new Mock<IPdfReader>();
            _pdfWriterMock = new Mock<IPdfWriter>();
            _replaceProcessor = new ReplaceProcessor(_pdfReaderMock.Object, _pdfWriterMock.Object);
        }

        [TestMethod]
        public async Task GivenReplaceProcessor_WhenReplaceCalled_SwapsPages()
        {
            // Arrange
            var inputPdfPath = "input.pdf";
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_replacedPage1with2.pdf";
            var inputDocumentMock = new Mock<IPdfDocument>();
            var outputDocumentMock = new Mock<IPdfDocument>();
            var page1Mock = new Mock<IPdfPage>();
            var page2Mock = new Mock<IPdfPage>();

            _pdfReaderMock.Setup(r => r.Read(inputPdfPath)).Returns(inputDocumentMock.Object);
            _pdfWriterMock.Setup(w => w.Write(outputPdfPath, false)).Returns(outputDocumentMock.Object);
            inputDocumentMock.Setup(d => d.GetNumberOfPages()).Returns(2);
            inputDocumentMock.Setup(d => d.GetPage(1)).Returns(page1Mock.Object);
            inputDocumentMock.Setup(d => d.GetPage(2)).Returns(page2Mock.Object);
            page1Mock.Setup(p => p.CopyTo(outputDocumentMock.Object)).Returns(page2Mock.Object);
            page2Mock.Setup(p => p.CopyTo(outputDocumentMock.Object)).Returns(page1Mock.Object);

            // Act
            await _replaceProcessor.Replace(inputPdfPath, 1, 2);

            // Assert
            _pdfReaderMock.Verify(r => r.Read(inputPdfPath), Times.Once);
            _pdfWriterMock.Verify(w => w.Write(outputPdfPath, false), Times.Once);
            inputDocumentMock.Verify(d => d.GetNumberOfPages(), Times.Once);
            inputDocumentMock.Verify(d => d.GetPage(1), Times.Once);
            inputDocumentMock.Verify(d => d.GetPage(2), Times.Once);
            page1Mock.Verify(p => p.CopyTo(outputDocumentMock.Object), Times.Once);
            page2Mock.Verify(p => p.CopyTo(outputDocumentMock.Object), Times.Once);
            outputDocumentMock.Verify(d => d.AddPage(page2Mock.Object), Times.Once);
            outputDocumentMock.Verify(d => d.AddPage(page1Mock.Object), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task GivenReplaceProcessor_WhenCalledWithInvalidPageNumbers_ThenThrowsArgumentException()
        {
            // Arrange
            var inputPdfPath = "input.pdf";
            var inputDocumentMock = new Mock<IPdfDocument>();

            _pdfReaderMock.Setup(r => r.Read(inputPdfPath)).Returns(inputDocumentMock.Object);
            inputDocumentMock.Setup(d => d.GetNumberOfPages()).Returns(2);

            // Act
            await _replaceProcessor.Replace(inputPdfPath, 0, 3);
        }
    }
}
