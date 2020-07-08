using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Models
{
    public class Person
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public IList<Result> CaloriesPerDay { get; set; } = new List<Result>();
    }
}
