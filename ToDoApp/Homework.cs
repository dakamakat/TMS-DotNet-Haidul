using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class Homework
    {
        private string _subject;

        private string _objective;

        static int count = 0;

        private List<Homework> homeworks = new List<Homework>(count);

        public List<Homework> Homeworks
        {
            get
            {
                return Homeworks;
            }
            set
            {
                if (count == count + 1)
                {
                    homeworks.Add(new Homework());
                }
            }
        }




        public DayOfWeek DayOfCreation { get; }
        
        public Homework() { }
        public Homework(string subject , string objective, DayOfWeek dayOfCreation)
        {
            count++;
            this._subject = subject;
            this._objective = objective;
            this.DayOfCreation = dayOfCreation;
            
           
        }
        public void GetInfo()
        {
            Console.WriteLine($"Subject: {_subject}  Objective: {_objective} DateOfCreation {DayOfCreation}");
            foreach(var a in homeworks)
            {
                Console.WriteLine(a);
            }
            
        }

    }
}
