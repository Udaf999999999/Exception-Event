using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_EventConsoleApp
{
    internal class SurnameSortList
    {
        private List<string> surnames;
        public List<string> Surname { get { return surnames; } }
        private int sortWay = 1;

        public delegate void SortCompliteDelegate(List<string> surnames);
        public event SortCompliteDelegate SortCompliteEvent;

        public SurnameSortList(List<string> surnames)
        {
            try
            {
                if (surnames == null || surnames.Count != 5) throw new ArgumentException("String count must be five.");
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
            for (int i = 0; i < surnames.Count; i++)
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
        private void ChooseSort(string choose)
        {
            try
            {
                sortWay = Int32.Parse(choose);
                if (sortWay != 1 && sortWay != 2)
                    throw new WrongInputSortWayException("Value must be 1 or 2!");
            }
            catch (Exception e) when (e is WrongInputSortWayException)
            {
                Console.WriteLine(DateTime.Now + ": " + e.Message + "\nThe default value is 1.");
                sortWay = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(DateTime.Now + ": " + e.Message +
                    "\nInput value is not a digit\nThe default value is 1.");
                sortWay = 1;
            }
            finally
            {
                if (sortWay == 1) SortAscend();
                else SortDescend();
            }
            OnSortComplite();
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
            surnames.Sort();
        }
        private void SortDescend()
        {
            surnames.Sort();
            surnames.Reverse();
        }
        protected virtual void OnSortComplite()
        {
            SortCompliteEvent?.Invoke(surnames);
        }
    }
}
