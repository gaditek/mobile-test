using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PureVPNTest
{
    class Utils
    {
        public static void writeToFile(string text)
        {
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"D:\PureVPNResult.txt", text);
        }
    }
}
