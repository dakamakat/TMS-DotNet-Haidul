using System;

namespace OrganizerN1
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            string CurrentDay = Convert.ToString(DateTime.Now.DayOfWeek);
            Console.WriteLine("Введите текущий день недели");
            string UserDay = Console.ReadLine();
            if (CurrentDay == UserDay)
            {
                Console.WriteLine("День недели совпадает");
            }
            else
            {
                Console.WriteLine("День недели не совпадает");
            }
            Console.ReadKey();
        }
    }
}
