using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrades
{
    public class Student : StudentBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;
        private List<double> grades = new List<double>();
        public Student(string firstName) : base(firstName)
        {
        }
        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(grade)}");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'F':
                    this.AddGrade(20);
                    break;
                default:
                    this.AddGrade(0);
                    break;
            }
        }
        public override Statistics GetStatistics()
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
            switch (result.Average)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'H';
                    break;
            }
            return result;
        }
    }
}
