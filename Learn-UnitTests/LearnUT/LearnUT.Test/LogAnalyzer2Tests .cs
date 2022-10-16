using LearnUT.Chapter2;
using NUnit.Framework;
using System;

namespace LearnUT.Test
{
    [TestFixture]
    public class LogAnalyzer2Tests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;
            LogAnalyzer log = new LogAnalyzer(myFakeManager);

            bool result = log.IsValidLogFileName("short.ext");

            Assert.True(result);
        }

        public void IsValidFileName_ExtManagerThrowsException_ReturnsFalse()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillThrow = new Exception("this is fake");

            LogAnalyzer log = new LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("anything.anyextension");
            Assert.False(result);
        }

        [Test]
        public void IsValidFileName_SupportedExtension_ReturnsTrue()
        {
            //set up the stub to use, make sure it returns true
            
            //ExtensionManagerFactory.SetManager(myFakeManager);

            //create analyzer and inject stub
            //LogAnalyzer log = new LogAnalyzer();

            //Assert logic assuming extension is supported
        }

        [Test]
        public void overrideTest()
        {
            FakeExtensionManager stub = new FakeExtensionManager();
            stub.WillBeValid = true;
            TestableLogAnalyzer logan = new TestableLogAnalyzer(stub);
            bool result = logan.IsValidLogFileName("file.ext");
            Assert.True(result);
        }
    }
}
