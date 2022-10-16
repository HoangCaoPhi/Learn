using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Stub
/// </summary>
namespace LearnUT.Chapter2
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;
        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }
        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);
        }
    }
}
