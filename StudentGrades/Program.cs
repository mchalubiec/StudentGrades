using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Michał");
            while (true)
            {

            }
            student.AddGrade(4.5);
            student.AddGrade(4.0);
            student.AddGrade(5.0);
            var testStat = student.GetStatistics();
        }
    }
}
