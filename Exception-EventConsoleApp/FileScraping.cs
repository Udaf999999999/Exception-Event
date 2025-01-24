using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_EventConsoleApp
{
    internal class FileScraping
    {
        public FileScraping(string filePath)
        {
            Exception[] exceptions = new Exception[]
            {
                new ArgumentNullException("Path's string is null!"),
                new DriveNotFoundException("Drive isn't accepteble or found!"),
                new FileNotFoundException("File not found!"),
                new PathTooLongException("Path is too long!"),
                new MyException("MyException!")
            };

            //try
            //{
            //    if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException("Path's string is null!");
            //    string content = File.ReadAllText(filePath);
            //    Console.WriteLine(content);
            //}
            //catch (Exception ex)
            //{
            //    //foreach (var ex2 in exceptions)
            //    //{
            //    //    if (ex.GetType() == ex2.GetType())
            //    //    {
            //    //        Console.WriteLine(ex2.Message);
            //    //    }
            //    //}
            //    Console.WriteLine("ERROR");
            //}
        }
    }
}
