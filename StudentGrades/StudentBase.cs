using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrades
{
    public abstract class StudentBase : NameObject
    {
        public StudentBase(string firstName) : base(firstName)
        {

        }
        public abstract void AddGrade(double grade);
    }
}
