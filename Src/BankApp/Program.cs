using BankApp.Models;
using System;

namespace BankApp
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
                            ProgrammActions.InputClient();
                            break;
                        }
                    case 2:
                        {
                            ProgrammActions.DeleteClient();
                            break;
                        }
                    case 3:
                        {
                            ProgrammActions.GetClient();
                            break;
                        }
                    case 4:
                        {
                            ProgrammActions.GetAllClients();
                            break;
                        }
                    case 5:
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
