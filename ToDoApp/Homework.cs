using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Homework
    {
        private string _subject;

        private string _objective;

        private readonly DayOfWeek dayOfCreation = DateTime.Now.DayOfWeek;

        List<Homework> listOfHomeworks { get; set; } = new List<Homework>();



        public Homework() { }
        public Homework(string subject , string objective, DayOfWeek dayOfCreation)

        {
            this._subject = subject;
            this._objective = objective;
            this.dayOfCreation = dayOfCreation;
            
           
        }
        public void GetInfo(Homework homework)
        {
            foreach (var goal in homework.listOfHomeworks)
            {
                Console.WriteLine($"Subject: {goal._subject}  Objective: {goal._objective} DayOfCreation {goal.dayOfCreation}");
            }

        }
        public void AddHomework(Homework homework)
        {
            Console.WriteLine("Enter the number of homeworks that you wanna add");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < input; i++)
                {
                    Console.Write("Subject: ");
                    string subject = Console.ReadLine();
                    Console.Write("Objective: ");
                    string objective = Console.ReadLine();
                    Homework goal = new Homework(subject, objective, DateTime.Now.DayOfWeek);
                    homework.listOfHomeworks.Add(goal);
        }

    }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number");
            }
        }
        public void DeleteHomework(Homework homework)
        {
            try
            {
                Console.Write("Enter an index of homework :");
                int input = Convert.ToInt32(Console.ReadLine());
                if (homework.listOfHomeworks != null)
                {
                    homework.listOfHomeworks.RemoveAt(input);
                }
                else
                    Console.WriteLine("There is no homeworks");
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a number of homework which y wanna delete");
            
            }
            
        }
    }
}
