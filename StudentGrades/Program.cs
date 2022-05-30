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
                Console.WriteLine($"Hello! Enter grade for {student.FirstName}");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    student.AddGrade(grade);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            var statistics = student.GetStatistics();
            Console.WriteLine($"High: {statistics.High}");
            Console.WriteLine($"Low: {statistics.Low}");
            Console.WriteLine($"Average: {statistics.Average}");
            Console.WriteLine($"Letter: {statistics.Letter}");
        }
    }
}
