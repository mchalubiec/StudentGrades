using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrades
{
    public abstract class StudentBase : NameObject, IStudent
    {
        public StudentBase(string firstName) : base(firstName)
        {
        }
        public event Student.GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade);
        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
