using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearnUT.Chapter1
{
    public class LogAnalyzer
    {
        //public bool WasLastFileNameValid { get; set; }
        //public bool IsValidLogFileName(string fileName)
        //{
        //    WasLastFileNameValid = false;
        //    if (string.IsNullOrEmpty(fileName))
        //    {
        //        throw new ArgumentException("filename has to be provided");

        //    }
        //    if (!fileName.EndsWith(".SLF",
        //    StringComparison.CurrentCultureIgnoreCase))
        //    {
        //        return false;
        //    }
        //    WasLastFileNameValid = true;
        //    return true;
        //}

        // Using factory
        private IExtensionManager manager;
        public LogAnalyzer()
        {
           // manager = ExtensionManagerFactory.Create();
        }
        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName)
            && Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }
    }
}
