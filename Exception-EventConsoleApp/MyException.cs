using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_EventConsoleApp
{
    internal class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("My Exception happened:" + DateTime.Now);
        }

        public MyException(string message) : base(message)
        {
            Console.WriteLine("My Exception happened:" + DateTime.Now);
        }
    }
}
