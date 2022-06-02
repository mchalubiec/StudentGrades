using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentGrades
{
    public class SavedStudent : StudentBase
    {
        public SavedStudent(string firstName) : base(firstName)
        {
        }
        public override event Student.GradeAddedDelegate GradeAdded;
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
            throw new NotImplementedException();
        }
    }
}
