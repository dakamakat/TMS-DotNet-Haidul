using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Interfaces
{
    interface IUserManager
    {
        void CreateUser(string name, int age, double weight, double height);
        void DoExerciseRun(string id, double distance);
        void DoExerciseJump(string id, int count);
        void GetStatistics(string id);
    }
}
