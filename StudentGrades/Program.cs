using System;

namespace StudentGrades
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    class Program
    {
        static void Main(string[] args)
        {
            var student = new SavedStudent("Michał");
            EnterGrade(student);
            var statistics = student.GetStatistics();
            Console.WriteLine($"High: {statistics.High}");
            Console.WriteLine($"Low: {statistics.Low}");
            Console.WriteLine($"Average: {statistics.Average}");
            Console.WriteLine($"Letter: {statistics.Letter}");
        }

        private static void EnterGrade(IStudent student)
        {
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
        }

        private static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("New grade is added");
        }
    }
}
