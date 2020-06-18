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
        static void SameDay(string UserDay)
        {
         string CurrentDay = Convert.ToString(DateTime.Now.DayOfWeek);          
            if (CurrentDay == UserDay)
            {
                Console.WriteLine("День недели совпадает"); 
            }
            else
            {
                Console.WriteLine("День недели не совпадает");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий день недели");
            string UserDay = Console.ReadLine();
            SameDay(UserDay);
            Console.ReadLine();
        }
        
    }
}
