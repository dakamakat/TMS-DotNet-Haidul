using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Interfaces;
using ZooApp.Enums;

namespace ZooApp.Managers
{
    class AnimalManager : IAnimalManager
    {
        public void GetInfo(Animal animal)
        {
            Console.WriteLine($"Id: {animal.GetID()}");
            Console.WriteLine($"Name: {animal.Name}");
            Console.WriteLine($"Kind: {animal.Kind}");
            Console.WriteLine($"Passport: {animal.GetPassport()}");
        }

        public void Rename(Animal anumal,string name)
        {
            anumal.Name = name;
        }

        public void SetPassport(Animal animal, string passport)
        {
            animal.SetPassport(passport);
        }
        public Animal CreateAnimal()
        {
            return new Animal(); 
        }
        public Animal CreateAnimal(string name)
        {
            return new Animal(name);
        }
        public Animal CreateAnimal(string name, KindType kind)
        {
            return new Animal(name, kind);
        }
        public Animal CreateAnimal(string name, KindType kind, string passport)
        {
            return new Animal(name, kind, passport); 
        }

    }
}
