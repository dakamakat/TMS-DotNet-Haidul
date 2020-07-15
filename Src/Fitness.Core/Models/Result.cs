using Fitness.Core.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Fitness.Core.Models
{
    public class Result
    {
        public DateTime Date { get; set; }
        public ExerciseType Type { get; set; }
        public double Calories { get; set; }
    }
}
