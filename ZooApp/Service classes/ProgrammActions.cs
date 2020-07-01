using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ZooApp.Managers
{
    static class ProgrammActions
    {
        private static readonly AnimalManager _animalManager = new AnimalManager();
        private static readonly ZooManager _zoo = new ZooManager();

        public static void InputAnimal()
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Animal animal;

            if (!string.IsNullOrEmpty(name))
            {
                animal = _animalManager.CreateAnimal(name);
            }
            else
            {
                animal = _animalManager.CreateAnimal();
            }
            _zoo.AddAnimal(animal);
            Console.WriteLine("Животное успешно добавлено");

        }
        public static void DeleteAnimal()
        {
            try
            {
                Console.Write("Введите номер животного которое вы хотите удалить: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (_zoo.animals != null)
                {
                    _zoo.animals.RemoveAt(input - 1);
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
        public static void GetAllAnimals()
        {
            _zoo.GetAllAnimals();
        }
        public static void GetAnimal()
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
        public static void ShowMenu()
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1.Добавить животное:");
            Console.WriteLine("2.Удалить животное:");
            Console.WriteLine("3.Показать животное:");
            Console.WriteLine("4.Показать всех животных:");

        }
    }
}
