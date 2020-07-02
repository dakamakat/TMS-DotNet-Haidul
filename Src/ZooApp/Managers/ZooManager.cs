    using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Managers
{
    class ZooManager
    {
        private readonly AnimalManager _animalmanager;
        public List<Animal> animals = new List<Animal>();

        public ZooManager()
        {
            _animalmanager = new AnimalManager();
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void Remove(Animal animal)
        {
            animals.Remove(animal);
        }
        public void GetAllAnimals()
        {
            if (animals.Count > 0)
            {
                foreach (var animal in animals)
                {
                    _animalmanager.GetInfo(animal);
                }
            }
            else
            {
                Console.WriteLine("Животных в зоопарке нет");
            }           
        }
        public void GetAnimal(Animal animal)
        {
            _animalmanager.GetInfo(animal);
        }
        public Animal GetAnimalbyId(Guid id)
        {
            return animals.Find(x => x.GetID() == id);
        }
    }
}
