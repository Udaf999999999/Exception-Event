using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_EventConsoleApp
{
    internal class FileScraping
    {
        public FileScraping(string filePath, string keyWord)
        {
            Exception[] exceptions = new Exception[]
            {
                new MyException("Keyword not found!"),
                new ArgumentNullException("Path's string is null!"),
                new UnauthorizedAccessException ("No access to file!"),
                new FileNotFoundException("File not found!"),
                new PathTooLongException("Path is too long!")
            };

            try
            {
                if (string.IsNullOrEmpty(filePath)) throw exceptions[1];
                if (!File.Exists(filePath)) throw exceptions[3];
                string content = File.ReadAllText(filePath);
                if (!content.Contains(keyWord)) throw exceptions[0];
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                foreach (var ex2 in exceptions)
                {
                    if (ex.GetType() == ex2.GetType())
                    {
                        Console.WriteLine(ex2.Message);
                    }
                }
                Console.WriteLine("ERROR");
            }
        }
    }
}
