using Microsoft.VisualStudio.TestTools.UnitTesting;
using PdfTool.CLI.Parser;
using System;

namespace PdfTool.UnitTests
{
    [TestClass]
    public class ArgumentsFactoryTests
    {
        private ArgumentsFactory _factory;

        [TestInitialize]
        public void TestInitialize()
        {
            _factory = new ArgumentsFactory(new OptionsParser());
        }

        [TestMethod]
        public void GivenCreate_WithMultipleInputOptions_ThenParseCorrect()
        {
            var args = new[] { "merge", "--input", "C:/MyPath1", "C:/MyPath2" };
            var result = _factory.Create(args);

            Assert.AreEqual(2, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath1", result.ReferencePaths[0]);
            Assert.AreEqual("C:/MyPath2", result.ReferencePaths[1]);
        }

        [TestMethod]
        public void GivenCreate_WithFromAndToOptions_ThenParseCorrect()
        {
            var args = new[] { "extract", "--input", "C:/MyPath", "--from:2", "--to:4" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(4, result.ToPage);
        }

        [TestMethod]
        public void GivenCreate_WithPageOption_ThenParseCorrect()
        {
            var args = new[] { "replace", "--input", "C:/MyPath", "--page", "2", "4" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(4, result.ToPage);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void GivenCreate_WithFromAndPageOptions_ShouldThrowException()
        {
            var args = new[] { "extract", "--input", "C:/MyPath", "--from:2", "--page", "3", "4" };
            _factory.Create(args);
        }

        [TestMethod]
        public void GivenCreate_WithoutOptions_ThenParseCorrect()
        {
            var args = new[] { "extract", "C:/MyPath", "2", "4" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(4, result.ToPage);
        }

        [TestMethod]
        public void GivenCreate_WithoutOptionsWithSinglePage_ThenParseCorrect()
        {
            var args = new[] { "replace", "C:/MyPath", "2" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(0, result.ToPage);
        }

        [TestMethod]
        public void GivenCreate_WithShortOptions_ThenParseCorrect()
        {
            var args = new[] { "merge", "-i", "C:/MyPath1", "C:/MyPath2" };
            var result = _factory.Create(args);

            Assert.AreEqual(2, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath1", result.ReferencePaths[0]);
            Assert.AreEqual("C:/MyPath2", result.ReferencePaths[1]);
        }

        [TestMethod]
        public void GivenCreate_WithMixedOptions_ThenParseCorrect()
        {
            var args = new[] { "replace", "--input", "C:/MyPath", "-p", "2", "4" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(4, result.ToPage);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GivenCreate_WithInvalidPageNumber_ShouldThrowException()
        {
            var args = new[] { "extract", "--input", "C:/MyPath", "--from:abc", "--to:4" };
            _factory.Create(args);
        }

    }


}
