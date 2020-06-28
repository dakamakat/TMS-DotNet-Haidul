using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Enums;

namespace ZooApp
{
    class Animal
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
        public Guid GetID()
        {
            return _id;
        }
        public string GetPassport()
        {
            return _passport;
        }
        public void SetPassport(string passport)
        {
            _passport = passport;
        }
    }

}
