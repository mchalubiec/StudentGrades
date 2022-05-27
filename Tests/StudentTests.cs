using StudentGrades;
using Xunit;

namespace Tests
{
    public class StudentTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var student = new Student("Micha³");
            student.AddGrade(87.2);
            student.AddGrade(90.5);
            student.AddGrade(77.3);
            //act
            var result = student.GetStatistics();
            //assert
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
            Assert.Equal(85, result.Average);
        }
    }
}
