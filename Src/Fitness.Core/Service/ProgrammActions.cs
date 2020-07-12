using Fitness.Core.Interfaces;
using Fitness.Core.Managers;
using Fitness.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Core.Service
{
    public static class ProgrammActions
    {
        private static readonly UserManager _userManager = new UserManager();
        public static void AddUser()
        {
            Console.WriteLine("Enter name of user:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter age of user:");
            int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Enter weight of user:");
            double.TryParse(Console.ReadLine(), out double weight);
            Console.WriteLine("Enter height of user:");
            double.TryParse(Console.ReadLine(), out double height);
            if (!string.IsNullOrEmpty(name))
            {
                _userManager.CreateUser(name, age, weight, height);
            }
            else
            {
                Console.WriteLine("Invalid name");
            }
        }
        public static void RemoveUser()
        {
            _userManager.DeleteUser();
        }
        public static void DoExersize()
        {
            Console.WriteLine("Enter Id of user:");
            var id = Console.ReadLine();
            if (!string.IsNullOrEmpty(id))
            {
                Console.WriteLine("Choose exersize:\n1. Jump\n2. Run");
                int.TryParse(Console.ReadLine(), out int result);
                switch (result)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter a number of jumps:");
                            int.TryParse(Console.ReadLine(), out int count);
                            _userManager.DoExerciseJump(id, count);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter a distance:");
                            int.TryParse(Console.ReadLine(), out int count);
                            _userManager.DoExerciseJump(id, count);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Invalid id");
            }          
        }
        public static void GetStatistics()
        {
            _userManager.GetStatistics();
        }
        public static void ShowAllUsers()
        {
            _userManager.GetAllUsers();
        }
        public static void ShowMenu()
        {
            Console.WriteLine("Choose action :");
            Console.WriteLine("1.Add new user :");
            Console.WriteLine("2.Delete user :");
            Console.WriteLine("3.Do exersize");
            Console.WriteLine("4.Get statistics");
            Console.WriteLine("5.Show all users :");
            Console.WriteLine("6.Exit");
        }
    }
}
