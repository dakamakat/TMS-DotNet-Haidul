using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Models
{
    public class User
    {
        public string Id { get;} = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public IList<Result> CaloriesPerDay { get; set; } = new List<Result>();
        public void GetInfo()
        {
            Console.WriteLine($"Name of user : {Name}\nAge of user : {Age}\nWeight of user : {Weight}\nHeight of user : {Height}\nId of user :{Id}\n");
        }
    }
}
