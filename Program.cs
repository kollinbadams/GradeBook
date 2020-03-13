using System;
using System.Collections.Generic;

namespace GradeBook
{
    

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Kollins Gradebook");
            var grades = new List<double>(){ 56, 17, 18, 32, 68, 69.69};

            foreach(var grade in grades){
                book.AddGrade(grade);
            }
            var stats = book.GetStatistics();
           book.DisplayStatistics(stats);

        }
    }
}
