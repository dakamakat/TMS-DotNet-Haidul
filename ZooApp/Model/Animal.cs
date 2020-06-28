using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Enums;

namespace ZooApp
{
    class Animal:IAnimal
    {
        private readonly Guid _id = Guid.NewGuid();
        private string _passport;
        public string Name { get; set; }
        public KindType Kind { get; set; }
        public Animal()
        {     
            Name = "Noname";
            Kind = KindType.None;
            _passport = Guid.NewGuid().ToString();
        }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, KindType kind)
        {
            Name = name;
            Kind = kind;
        }

        public Animal( string name, KindType kind,string passport) 
        {

            Name = name;
            Kind = kind;
            _passport = passport;
        }
        public void Rename(string name)
        {
            Name = name;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Id: {_id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Kind: {Kind}");
            Console.WriteLine($"Passport: {_passport}");

        }
    }

}
