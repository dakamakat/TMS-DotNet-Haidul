using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework homework1 = new Homework();
            bool execution = true;
            while (execution == true)
            {
                
                string a = "";
                Console.WriteLine(@"Choose variant:
            1. Create homework.
            2. Delete homework.
            3. Show all homeworks.
            4. End programm");
                

                string b = Console.ReadLine();
                switch (b)
                {
                    case "1":
                        {
                            homework1.AddHomework(homework1);
                            break;
                        }
                    case "2":
                        {
                            homework1.DeleteHomework(homework1);
                            break;
                        }
                    case "3":
                        {
                            homework1.GetInfo(homework1);
                            break;
                        }
                    case "4":
                        {
                            execution = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a suggested number");
                            break;
                        }

                }
            }
            
            Console.ReadLine();

        }
    }
}
