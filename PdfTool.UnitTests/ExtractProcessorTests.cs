﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PdfTool.Processors;
using PdfTool.Processors.Adapter;
using PdfTool.Services;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PdfTool.UnitTests
{
    [TestClass]
    public class ExtractProcessorTests
    {
        private Mock<IPageRemoveService> _pageRemoveServiceMock;
        private Mock<IPdfReader> _pdfReaderMock;
        private Mock<IPdfDocument> _pdfDocumentMock;
        private ExtractProcessor _extractProcessor;

        [TestInitialize]
        public void TestInitialize()
        {
            _pageRemoveServiceMock = new Mock<IPageRemoveService>();
            _pdfReaderMock = new Mock<IPdfReader>();
            _pdfDocumentMock = new Mock<IPdfDocument>();

            _extractProcessor = new ExtractProcessor(_pageRemoveServiceMock.Object, _pdfReaderMock.Object);
        }

        [TestMethod]
        public async Task Extract_ShouldCallRemovePagesWithCorrectParameters()
        {
            // Arrange
            const string inputPdfPath = "input.pdf";
            const int fromPage = 2;
            const int toPage = 5;
            const int pageCount = 10;
            var args = new ProcessorArgs()
            {
                FromPage = fromPage,
                ToPage = toPage,
            };
            args.ReferencePaths.Add(inputPdfPath);
            _pdfReaderMock.Setup(m => m.Read(inputPdfPath)).Returns(_pdfDocumentMock.Object);
            _pdfDocumentMock.Setup(m => m.GetNumberOfPages()).Returns(pageCount);

            // Act
            await _extractProcessor.ExecuteAsync(args);

            // Assert
            _pageRemoveServiceMock.Verify(m => m.RemovePages(
                inputPdfPath,
                It.Is<string>(s => s.Contains($"{Path.GetFileNameWithoutExtension(inputPdfPath)}_extractedPages{fromPage}-{toPage}.pdf")),
                It.Is<int[]>(pages => pages.SequenceEqual(Enumerable.Range(1, pageCount).Except(Enumerable.Range(fromPage, toPage - fromPage + 1)).ToArray()))
            ), Times.Once);
        }
    }
}
