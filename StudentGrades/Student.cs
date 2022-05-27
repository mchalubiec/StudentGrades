using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrades
{
    public class Student
    {
        private string name;
        private List<double> grades = new List<double>();
        public Student(string name)
        {
            this.name = name;
        }
    }
}
