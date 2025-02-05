using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_EventConsoleApp
{
    internal class MyException : Exception
    {

        public MyException(string message) : base(message)
        {
            File.AppendAllText("log.txt", Environment.NewLine + 
                DateTime.Now.ToString("dd MM yyyy HH mm ss") + " File don't contain keyword. Details: " + message);
        }
    }
}
