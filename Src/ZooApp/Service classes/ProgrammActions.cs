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
            Console.WriteLine("Введите пасспорт: ");
            var passport = Console.ReadLine();
            if (!string.IsNullOrEmpty(passport))
            {
                animal.SetPassport(passport);
            }
            Console.WriteLine("Укажите тип животного:\n 1 - Хищник \n 2 - травоядное ");
            int.TryParse(Console.ReadLine(), out int userInput);
            switch(userInput)
            {
                case 1:
                    animal.Kind = Enums.KindType.Predator;
                    break;
                case 2:
                    animal.Kind = Enums.KindType.Herbivorus;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод");
                    animal.Kind = Enums.KindType.None;
                    break;
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
            Animal animal;
            if ((animal = ChooseAnimal()) != null)
            {
                _zoo.GetAnimal(animal);
            }
        }
        private static Animal ChooseAnimal()
        {
            Console.Write("Введите ID животного: ");
            Animal animal;
            if (Guid.TryParse(Console.ReadLine(), out Guid id) && (animal = _zoo.GetAnimalbyId(id)) != null)
            {
                return animal;
            }
            else
            {
                Console.WriteLine("Животное с таким ID не найдено.");
                return null;
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
