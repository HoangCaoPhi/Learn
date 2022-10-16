using System;
using System.Collections.Generic;
using System.Text;

namespace LearnUT
{
    public class ExtensionManagerFactory
    {
        private IExtensionManager customManager = null;
        public IExtensionManager Create()
        {
            if (customManager != null) return customManager;
            return new FileExtensionManager();
        }
        public void SetManager(IExtensionManager mgr)
        {
            customManager = mgr;
        }
    }
}
