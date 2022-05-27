using StudentGrades;
using Xunit;

namespace Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetStudentReturnsDifferentObjects()
        {
            var student1 = GetStudent("Jan");
            var student2 = GetStudent("Tomek");
            Assert.Equal("Jan", student1.Name);
            Assert.Equal("Tomek", student2.Name);
        }
        private Student GetStudent(string name)
        {
            return new Student(name);
        }
    }
}
