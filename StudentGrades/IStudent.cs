using System;
using System.Collections.Generic;
using System.Text;
using static StudentGrades.Student;

namespace StudentGrades
{
    public interface IStudent
    {
        string firstName { get; set; }
        void AddGrade(double grade);
        Statistics GetStatistics();
        event GradeAddedDelegate GradeAdded;
    }
}
