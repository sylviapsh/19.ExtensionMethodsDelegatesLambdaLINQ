using System;
using System.Text;

namespace ExtensionOfSubstring
{
    class ExtensionOfSubstringTest
    {
        static void Main()
        {
            StringBuilder testExtension = new StringBuilder();
            testExtension.Append("This tests the substring extension method");
            Console.WriteLine(testExtension.Substring(15));
            Console.WriteLine(testExtension.Substring(5,4));
        }
    }
}
