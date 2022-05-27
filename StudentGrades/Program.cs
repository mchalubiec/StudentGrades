using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Student("Michał");
            employee.AddGrade(4.5);
            employee.AddGrade(4.0);
            employee.AddGrade(5.0);
            employee.GetStatistics();
        }
    }
}
