using Fitness.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Managers
{
    public class ExerciseManager:IExerciseManager
    {
        public double Jump(int count, double weight) => count * weight * 0.05;
        public double Run(double distance, double weight) => distance * weight * 0.3;
    }
}
