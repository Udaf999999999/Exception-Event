using System;
using System.Collections.Generic;
using System.Globalization;
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
        public string[] surnames = new string[5];//Изменить модефикатор

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
            Console.WriteLine("Enter 1, to sort in ascend, or 2 to sort in descend.");
            string choose = Console.ReadLine();
            ChooseSort(choose);
        }
        public void Sort(string choose)
        {
            ChooseSort(choose);
        }
        public void Sort(int sortWay)
        {
            //Дореализовать
        }
        private void ChooseSort(string choose)
        {
            int sortWay;
            try
            {
                sortWay = Int32.Parse(choose);
                if (sortWay != 1 && sortWay != 2)
                    throw new WrongInputSortWayException("Value must be 1 or 2!");

                if (sortWay == 1) SortAscend();
                else SortDescend();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ShowSurnames()
        {
            foreach (string s in surnames)
            {
                Console.WriteLine(s);
            }
        }
        private void SortAscend()
        {
            Array.Sort(surnames);
        }
        private void SortDescend()
        {
            Array.Sort(surnames);
            Array.Reverse(surnames);
        }
    }
}
