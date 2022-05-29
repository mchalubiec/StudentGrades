using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrades
{
    public class Student
    {
        private string firstName;
        public string FirstName
        { 
            get { return firstName; }
            set { this.firstName = value; }
        }

        private List<double> grades = new List<double>();
        public Student(string firstName)
        {
            this.firstName = firstName;
        }
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (var grade in this.grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= grades.Count;
            return result;
        }
    }
}
