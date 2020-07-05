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
                            ProgrammActions.InputClient();
                            break;
                        }
                    case 3:
                        {
                            ProgrammActions.InputClient();
                            break;
                        }
                    case 4:
                        {
                            ProgrammActions.DeleteClient();
                            break;
                        }
                    case 5:
                        {
                            ProgrammActions.GetClient();
                            break;
                        }
                    case 6:
                        {
                            ProgrammActions.GetAllClients();
                            break;
                        }
                    case 7:
                        {
                            ProgrammActions.TakeMoney();
                        }
                        break;
                    case 8:
                        {
                            ProgrammActions.PutMoney();
                        }
                        break;
                    case 9:
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
