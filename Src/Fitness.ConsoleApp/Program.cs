using Fitness.Core.Models;
using System;
using Fitness.Core.Managers;
using System.ComponentModel;
using System.Collections.Generic;
using Fitness.Core.Service;

namespace Fitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ProgrammActions.ShowMenu();
                int.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        {
                            ProgrammActions.AddUser();
                            break;
                        }
                    case 2:
                        {
                            ProgrammActions.RemoveUser();
                            break;
                        }
                    case 3:
                        {
                            ProgrammActions.DoExersize();
                            break;
                        }
                    case 4:
                        {
                            ProgrammActions.GetStatistics();
                        }
                        break;
                    case 5:
                        {
                            ProgrammActions.ShowAllUsers();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Command doesn't exists:");
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
