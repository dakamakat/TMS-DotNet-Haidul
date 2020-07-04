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
                            ProgrammActions.InputAnimal();
                            break;
                        }
                    case 2:
                        {
                            ProgrammActions.DeleteAnimal();
                            break;
                        }
                    case 3:
                        {
                            ProgrammActions.GetAnimal();
                            break;
                        }
                    case 4:
                        {
                            ProgrammActions.GetAllAnimals();
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Команда не найдена:");
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
