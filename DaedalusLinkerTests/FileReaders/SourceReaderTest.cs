using System;
using DaedalusLinker.FileReaders;
using DaedalusLinker.Exceptions;
using NUnit.Framework;

namespace DeadalusLinkerTests.FileReaders
{
    [TestFixture]
    public class SourceReaderTest
    {
        [Test]
        public void SourceReaderWithBadExtension()
        {
            try
            {
                SourceReader sr = new SourceReader("simple.txt");
                Assert.Fail();
            }
            catch (BadExtensionException ex)
            {
                Assert.Pass();
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }
}