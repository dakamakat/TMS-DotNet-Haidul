using Fitness.Core.Models;
using System;
using Fitness.Core.Managers;
using System.ComponentModel;
using System.Collections.Generic;
using Fitness.Core.

namespace Fitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.CreateUser("James", 33, 120, 166);
            userManager.CreateUser("Mary", 43, 78, 173);
            userManager.GetAllUsers();
            while (true)
            {
                .ShowMenu();
                int.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        {
                            .InputClient();
                            break;
                        }
                    case 2:
                        {
                            ProgrammActions.InputAccount();
                            break;
                        }
                    case 3:
                        {
                            ProgrammActions.ConvertMoney();
                            break;
                        }
                    case 12:
                        {
                            Environment.Exit(0);
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
