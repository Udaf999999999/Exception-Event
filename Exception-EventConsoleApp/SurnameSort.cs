using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_EventConsoleApp
{
    public class WrongInputSortWayException : Exception
    {
        public WrongInputSortWayException(string message) : base(message) { }
    }
    public class SurnameSort
    {
        private string[] surnames = new string[5];

        public SurnameSort(string[] surnames)
        {
            try
            {
                if (surnames == null || surnames.Length != 5) throw new ArgumentException("String count must be five.");
                foreach (string s in surnames)
                {
                    if (string.IsNullOrEmpty(s)) throw new ArgumentException("Surname can't be empty!");
                }
                this.surnames = surnames;
            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }

        public void GetNamesFromKeyboard()
        {
            Console.WriteLine("Please, enter surnames");
            for (int i = 0; i < surnames.Length; i++)
            {
                Console.WriteLine("Enter " + (i + 1) + " surname:");
                surnames[i] = Console.ReadLine();
            }
        }
        public void Sort()
        {
            int sortWay;
            Console.WriteLine("Enter 1, to sort in ascend, or 2 to sort in descend.");
            try
            {
                sortWay = Int32.Parse(Console.ReadLine());
                if (sortWay != 1 && sortWay != 2)
                    throw new WrongInputSortWayException("Value must be 1 or 2!");

                if (sortWay == 1) SortAscend();
                else SortDescend();
            }
            catch
            {

            }
        }
        private void SortAscend()
        {

        }
        private void SortDescend()
        {

        }
    }
}
