using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            // var x = 3; Implicit typing: we don't specify the type of x
            // double[] numbers = new double[3] {12.7, 10.3, 6.11};
            // double[] numbers = new double[] {12.7, 10.3, 6.11};
            // numbers[0] = 12.7;
            // numbers[1] = 10.3;
            // numbers[2] = 6.11;
            // double[] numbers = new[] {12.7, 10.3, 6.11};

            var book = new Book("Oishika's Gradebook");
            // book.AddGrade(89.1);
            // book.AddGrade(90.1);
            // book.AddGrade(77.5);
            // book.AddGrade(56.1);
            while (true)
            {
                Console.WriteLine("Enter a grade or q to quit:");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                var grade = double.Parse(input);
                book.AddGrade(grade);
                
            }
            
            // book.showStatistics();
            /*
            List<double> grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
        
            double result = numbers[0] + numbers[1] + numbers[2];
            double average = book.computeAverage();
            Console.WriteLine($"The average for this class is, {average}");
            double result = 0;
            foreach(double number in grades)
            {
                result += number;
            }
            double average = result/grades.Count;

            System.Console.WriteLine(average);

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
            */
        }
    }

}