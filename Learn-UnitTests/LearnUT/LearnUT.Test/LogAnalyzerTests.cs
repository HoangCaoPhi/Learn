using LearnUT.Chapter1;
using NUnit.Framework;
using System;

namespace LearnUT.Test
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        //private LogAnalyzer m_analyzer = null;
        //[SetUp]
        //public void Setup()
        //{
        //    m_analyzer = new LogAnalyzer();
        //}
        //[Test]
        //public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        //{
        //    bool result = m_analyzer
        //    .IsValidLogFileName("whatever.slf");
        //    Assert.IsTrue(result, "filename should be valid!");
        //}
        //[Test]
        //public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        //{
        //    bool result = m_analyzer
        //    .IsValidLogFileName("whatever.slf");
        //    Assert.IsTrue(result, "filename should be valid!");
        //}

        ////[Test]
        ////public void IsValidFileName_EmptyFileName_Throws()
        ////{
        ////    LogAnalyzer la = MakeAnalyzer();
        ////    var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));
        ////    StringAssert.Contains("filename has to be provided",
        ////    ex.Message);
        ////}

        //[Test]
        //[Category("Fast Tests")]
        //public void IsValidFileName_EmptyFileName_ThrowsFluent()
        //{
        //    LogAnalyzer la = MakeAnalyzer();
        //    var ex =
        //    Assert.Catch<ArgumentException>(() => la.IsValidLogFileName(""));
        //    Assert.That(ex.Message, Is.AnyOf("filename has to be provided"));
        //}

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    //the line below is included to show an anti pattern.
        //    //This isn’t really needed. Don’t do it in real life.
        //    m_analyzer = null;
        //}

        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        {
            LogAnalyzer la = MakeAnalyzer();
            la.IsValidLogFileName(file);
           // Assert.AreEqual(expected, la.WasLastFileNameValid);
        }
    }
}
