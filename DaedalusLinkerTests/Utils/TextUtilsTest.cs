using NUnit.Framework;
using System;
using System.IO;
using System.Text;
using DaedalusLinker.Utils;

namespace DeadalusLinkerTests.Utils
{
    public class TestUtilsTest
    {
        [SetUp]
        public void Setup()
        {
        }

   

        [Test]
        public void TestStripCommentWithOnlyCommentString()
        {
            String testString = "//comment";
            String result = String.Empty;

            Assert.AreEqual(TextUtils.StripComments(testString), result);
        }

        [Test]
        public void TestStripCommentWithTextAndComment()
        {
            String testString = "const int a = 5;//comment";
            String result = "const int a = 5;";

            Assert.AreEqual(TextUtils.StripComments(testString), result);
        }

        [Test]
        public void TestStripCommentWithNoComment()
        {
            String testString = "const int a = 5;";
            String result = "const int a = 5;";

            Assert.AreEqual(TextUtils.StripComments(testString), result);
        }

   
    }
}