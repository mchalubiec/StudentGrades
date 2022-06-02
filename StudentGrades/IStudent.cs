using System;
using System.Collections.Generic;
using System.Text;
using static StudentGrades.Student;

namespace StudentGrades
{
    public interface IStudent
    {
        string FirstName { get; set; }
        void AddGrade(double grade);
        Statistics GetStatistics();
        event GradeAddedDelegate GradeAdded;
    }
}
