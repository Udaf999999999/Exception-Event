namespace Exception_EventConsoleApp
{
    internal class Program
    {
        public static void SurnameSortComplited(string[] surnames)
        {
            Console.WriteLine("Sort complite.");
        }
        static void Main(string[] args)
        {
            string[] strings = { "Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov" };
            SurnameSort surnameSort = new SurnameSort(strings);
            surnameSort.SortCompliteEvent += SurnameSortComplited;

            surnameSort.Sort();
            surnameSort.ShowSurnames();
            Console.WriteLine("Hello, World!");
        }
    }
}
