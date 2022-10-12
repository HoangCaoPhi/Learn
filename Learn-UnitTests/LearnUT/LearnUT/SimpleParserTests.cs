using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LearnUT
{
    class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    TestUtil.ShowProblem(testName,
    "Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                TestUtil.ShowProblem(testName, e.ToString());
            }
        }
    }
}
