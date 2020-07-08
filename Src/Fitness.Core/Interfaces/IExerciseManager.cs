using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Interfaces
{
    interface IExerciseManager
    {
        double Jump(int count, double weight);
        double Run(double distance, double weight);
    }
}
