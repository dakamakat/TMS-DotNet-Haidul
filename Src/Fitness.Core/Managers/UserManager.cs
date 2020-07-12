using Fitness.Core.Enums;
using Fitness.Core.Interfaces;
using Fitness.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Fitness.Core.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IList<User> people;
        private readonly IExerciseManager _exerciseManager;
        public UserManager()
        {
            people = new List<User>();
            _exerciseManager = new ExerciseManager();
        }
        public void CreateUser(string name,int age, double weight,double height)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"incorrect data {name}");  
                return;
            }
            if(age < 1 || age > 80)
            {
                Console.WriteLine($"incorrect data {age}");
                return;
            }
            if(weight > 250 || weight < 20)
            {
                Console.WriteLine($"incorrect data {weight}");
                return;
            }
            if(height < 30 || height > 250)
            {
                Console.WriteLine($"incorrect data {height}");
                return;
            }
            var user = new User
            {
                Name = name,
                Age = age,
                Weight = weight,
                Height = height
            };
            people.Add(user);
        }
        public void DeleteUser()
        {
            people.Remove(ChooseUserById());
        }
        public void DoExerciseRun(string id,double distance)
        {
            var user = ChooseUserById(id);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            var result = new Result
            {
                Date = DateTime.Now,
                Type = ExerciseType.Run,
                Calories = _exerciseManager.Run(distance, user.Weight)
            };
        
            user.CaloriesPerDay.Add(result);
        }
        public void DoExerciseJump(string id, int count)
        {
            var user = ChooseUserById(id);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            var result = new Result
            {
                Date = DateTime.Now,
                Type = ExerciseType.Jump,
                Calories = _exerciseManager.Jump(count, user.Weight)
            };

            user.CaloriesPerDay.Add(result);
        }
        public void GetStatistics(string id)
        {
            var user = ChooseUserById(id);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            foreach (var info in user.CaloriesPerDay)
            {
                Console.WriteLine($"Date : {info.Date}, Type : {info.Type}, Calories : {info.Calories}");
            }
        }
        public void GetStatistics()
        {
            var user = ChooseUserById();
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            foreach (var info in user.CaloriesPerDay)
            {
                Console.WriteLine($"Date : {info.Date}, Type : {info.Type}, Calories : {info.Calories}");
            }
        }
        public User ChooseUserById(string id)
        {
            var user = people.FirstOrDefault(u => u.Id.Contains(id));
            return user;
        }
        public User ChooseUserById()
        {
            Console.Write("Enter id of user: ");
            var id = Console.ReadLine();
            var user = people.FirstOrDefault(u => u.Id.Contains(id));
            return user;
        }
        public void GetAllUsers()
        {
            foreach(var user in people)
            {
                user.GetInfo();
            }
        }
    }
}
