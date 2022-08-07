using System;
using System.Collections.Generic;

namespace Gradebook 
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }
        public string Name
        {
            get;
            set;
        }
    }
    /*
    If we "internal class Book", then that would mean that the class Book could only
    be used within the current project. So we want to add public class Book. This
    is telling C# anyone who has reference to this project, can use this. 
    */
    public class Book  : NamedObject
    {
        //constructor that is explicitly defined. This forces an instance of a book to have a name. 
        public Book(string name) : base(name)
        {
            this.Name = name;
            grades = new List<double>();
        }

        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0) 
            {
                this.grades.Add(grade);
            }
            else 
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
            
        }

        public double computeHighestGrade()
        {
            double highestGrade = double.MinValue;
            foreach(double grade in grades)
            {
                if(grade > highestGrade)
                {   
                    highestGrade = grade;
                }
            }
            return highestGrade;
        }

        public double computeLowestGrade()
        {
            double lowestGrade = double.MaxValue;
            foreach(double grade in grades)
            {
                lowestGrade = Math.Min(lowestGrade, grade);
            }

            return lowestGrade;
        }

        public double computeAverageGrade()
        {
            double sum = 0;
            foreach(double grade in grades)
            {
                sum += grade;
            }
            double average = sum / grades.Count;
            return average;


            /*
            int index = 0;
            do 
            {
                //something
            } while ();
            while ()
            {

            }
            for(var index = 0; condition; change in condition) 
            {

            }
            */
        }

        public Statistics getStatistics()
        {
            Statistics result = new Statistics();
            result.high = computeHighestGrade();
            result.low = computeLowestGrade();
            result.average = computeAverageGrade();
            return result;
        }
        
        //cannot use implicit typing for member variables/fields
        // List<double> grades = new List<double> ();
        // public List<double> grades;
        public List<double> grades;

        // public string Name
        // {
        //     get
        //     {
        //         return name;
        //     }
        //     set
        //     {
        //         if (!String.IsNullOrEmpty(value))
        //         {
        //             name = value;
        //         }
        //     }
        // }
        // public string Name
        // {
        //     get; private set;
        // }
        //private string name;

    }

}