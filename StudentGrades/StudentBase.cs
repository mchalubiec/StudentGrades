using System;
using System.Collections.Generic;
using System.Text;
using static StudentGrades.Student;

namespace StudentGrades
{
    public abstract class StudentBase : NameObject, IStudent
    {
        public StudentBase(string firstName) : base(firstName)
        {
        }
        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public abstract Statistics GetStatistics();
    }
}
