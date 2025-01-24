namespace Exception_EventConsoleApp
{
    internal class Program
    {
        public static void SurnameSortComplited(string[] surnames)
        {
            Console.WriteLine("Sort complite.");
        }
        public static void SurnameSortComplitedList(List<string> surnames)
        {
            Console.WriteLine("Sort complite.");
        }
        static void Main(string[] args)
        {
            string[] strings = { "Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov" };
            List<string> list = ["Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov"];

            ////SurnameSort test
            //SurnameSort surnameSort = new SurnameSort(strings);
            //surnameSort.SortCompliteEvent += SurnameSortComplited;
            //surnameSort.Sort();
            //surnameSort.ShowSurnames();

            ////SurnameSortThrowEvent test
            //SurnameSortThrowEvent surnameSort = new SurnameSortThrowEvent(strings);
            //surnameSort.SortingEvent += SurnameSortComplited;
            //surnameSort.Sort();
            //surnameSort.ShowSurnames();

            ////SurnameSortList test
            //SurnameSortList surnameSortList = new SurnameSortList(list);
            //surnameSortList.SortCompliteEvent += SurnameSortComplitedList;
            //surnameSortList.Sort();
            //surnameSortList.ShowSurnames();

            ////SurnameSortThrowEventList
            //SurnameSortThrowEventList surnameSortThrowEventList = new SurnameSortThrowEventList(list);
            //surnameSortThrowEventList.SortingEvent += SurnameSortComplitedList;
            //surnameSortThrowEventList.Sort();
            //surnameSortThrowEventList.ShowSurnames();

            //FileScraping fileScraping = new FileScraping(@"H:\Windows\System32\drivers\etc\hosts");

            MyException2 myException = new MyException2("Это пользовательское исключение!");
            try
            {
                // Создаем экземпляр MyException и выбрасываем его
                throw new MyException2("Это пользовательское исключение!");
            }
            catch (MyException2 ex)
            {
                // Ловим и обрабатываем исключение
                Console.WriteLine($"Поймано исключение: {ex.Message}");
            }
        }
        public class MyException2 : Exception
        {
            public MyException2(string message) : base(message) { Console.WriteLine("23"); }
        }
    }
}
