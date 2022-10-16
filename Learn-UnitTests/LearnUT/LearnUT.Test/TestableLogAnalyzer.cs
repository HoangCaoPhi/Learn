using System;
using System.Collections.Generic;
using System.Text;

namespace LearnUT.Test
{
    public class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
    {
        public TestableLogAnalyzer(IExtensionManager mgr)
        {
            Manager = mgr;
        }
        public IExtensionManager Manager;
        protected override IExtensionManager GetManager()
        {
            return Manager;
        }
    }
}
