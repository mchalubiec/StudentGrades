using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentGrades
{
    public class SavedStudent : StudentBase
    {
        private List<double> grades = new List<double>();
        public SavedStudent(string firstName) : base(firstName)
        {
        }
        public override event GradeAddedDelegate GradeAdded;
        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{FirstName}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }
        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            using (var reader = File.OpenText($"{FirstName}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }           
            return result;
        }
    }
}
