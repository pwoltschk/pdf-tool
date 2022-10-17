﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PdfTool.CLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.UnitTests
{
    [TestClass]
    public class ArgumentsFactoryTests
    {
        private ArgumentsFactory _factory;

        [TestInitialize]
        public void TestInitialize()
        {
            _factory = new ArgumentsFactory();
        }

        [TestMethod]
        public void GivenCreate_WithMultipleInputOptions_ThenParseCorrect()
        {
            var args = new string[] { "merge", "--input", "\"C:/MyPath1\"", "\"C:/MyPath2\"" };
            var result = _factory.Create(args);

            Assert.AreEqual(2, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath1", result.ReferencePaths[0]);
            Assert.AreEqual("C:/MyPath2", result.ReferencePaths[1]);
        }

        [TestMethod]
        public void GivenCreate_WithFromAndToOptions_ThenParseCorrect()
        {
            var args = new string[] { "extract", "--input", "\"C:/MyPath\"", "--from:2", "--to:4" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(4, result.ToPage);
        }

        [TestMethod]
        public void GivenCreate_WithPageOption_ThenParseCorrect()
        {
            var args = new string[] { "replace", "--input", "\"C:/MyPath\"", "--page", "2", "4" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(4, result.ToPage);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void TestCreate_WithFromAndPageOptions_ShouldThrowException()
        {
            var args = new string[] { "extract", "--input", "\"C:/MyPath\"", "--from:2", "--page", "3", "4" };
            _factory.Create(args);
        }

        [TestMethod]
        public void WhenCreate_WithoutOptions_ThenParseCorrect()
        {
            var args = new string[] { "extract", "\"C:/MyPath\"", "2", "4" };
            var result = _factory.Create(args);

            Assert.AreEqual(1, result.ReferencePaths.Count);
            Assert.AreEqual("C:/MyPath", result.ReferencePaths[0]);
            Assert.AreEqual(2, result.FromPage);
            Assert.AreEqual(4, result.ToPage);
        }
    }


}