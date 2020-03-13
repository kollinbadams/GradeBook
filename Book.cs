using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        public Book(string name){
            grades = new List<double>();
            Name = name;
        }
         
        private List<double> grades;
        public string Name;
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics(){
            var result = new Statistics();
            result.low = double.MaxValue;
            result.high = double.MinValue;
            result.average = 0.0;

            foreach(var grade in grades){
                result.low = Math.Min(grade, result.low);
                result.high = Math.Max(grade, result.high);
                result.average += grade;
            }

            result.average /= grades.Count;

            return result;
            
        }

        public void DisplayStatistics(Statistics result){
            Console.WriteLine($"The Average is: {result.average}");
            Console.WriteLine($"The highest grade: {result.high}");
            Console.WriteLine($"The lowest grade: {result.low}");
        }
    }
}