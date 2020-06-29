using System;
using System.Dynamic;
using System.Linq;
using ZooApp.Managers;

namespace ZooApp
{
    class Program
    {
        private static readonly AnimalManager _animalManager = new AnimalManager();
        private static readonly ZooManager _zoo = new ZooManager();

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                int.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        {
                            InputAnimal();
                            break;
                        }
                    case 2:
                        {
                            DeleteAnimal();
                            break;
                        }
                    case 3:
                        {
                            GetAnimal();
                            break;
                        }
                    case 4:
                        {
                            GetAllAnimals();
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
        private static void InputAnimal()
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Animal animal;           

            if (!string.IsNullOrEmpty(name))
            {
                animal =_animalManager.CreateAnimal(name);
            }
            else
            {
                animal = _animalManager.CreateAnimal();
            }
            _zoo.AddAnimal(animal);
            Console.WriteLine("Животное успешно добавлено");

        }
        private static void DeleteAnimal()
        {
            try
            {
                Console.Write("Введите номер животного которое вы хотите удалить: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (_zoo.animals != null)
                {
                    _zoo.animals.RemoveAt(input-1);
                }
                else
                    Console.WriteLine("В зоопарке нет животных");
            }
            catch (Exception)
            {
                Console.WriteLine("В зоопарке нет животного с таким номером");
            }


            Console.WriteLine("Животное успешно удалено");
        }
        private static void GetAllAnimals()
        {
            _zoo.GetAllAnimals();
        }
        private static void GetAnimal()
        {
            try
            {
                int.TryParse(Console.ReadLine(), out int userInput);
                _zoo.GetAnimal(_zoo.animals.ElementAt(userInput));
            }
            catch (Exception)
            {

                Console.WriteLine("Животного с такин номером нет");
            }
            
        }
        private static void ShowMenu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1.Добавить животное:");
            Console.WriteLine("2.Удалить животное:");
            Console.WriteLine("3.Показать животное:");
            Console.WriteLine("4.Показать всех животных:");
             
        }
    }
}
