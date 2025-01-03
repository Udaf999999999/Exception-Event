namespace Exception_EventConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] strings = { "Orlov", "Sidorov", "Dragunov", "Smirnov", "Gavrilov" };
            SurnameSort surnameSort = new SurnameSort(strings);
            surnameSort.Sort("1");
            surnameSort.ShowSurnames();
            Console.WriteLine("Hello, World!");
        }
    }
}
