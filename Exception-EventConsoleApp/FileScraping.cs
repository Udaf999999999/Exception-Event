using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_EventConsoleApp
{
    internal class FileScraping
    {
        private FileInfo file;
        public FileScraping(string filePath)
        {
            //Exception[] exceptions = new Exception[]
            //{
            //    new MyException("MyException!"),
            //    new ArgumentNullException("Path's string is null!"),
            //    new DriveNotFoundException("Drive isn't accepteble or found!"),
            //    new FileNotFoundException("File not found!"),
            //    new PathTooLongException("Path is too long!")
            //};
            Exception[] exceptions = {System.AggregateException };

            try
            {

            }
            catch (Exception ex)
            {
                //foreach (var ex2 in exceptions)
                //{
                //    if (ex is ex2)
                //    {
                //        Console.WriteLine(ex2.Message);
                //    }
                //}
            }
        }
        public void Scraping()
        {

        }
    }
}
