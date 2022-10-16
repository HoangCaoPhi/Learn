using System;
using System.Collections.Generic;
using System.Text;

namespace LearnUT
{
    public class AlwaysValidFakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
