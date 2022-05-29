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
            Assert.Equal("Jan", student1.FirstName);
            Assert.Equal("Tomek", student2.FirstName);
        }
        [Fact]
        public void CanSetNameFromReferance()
        {
            var student = GetStudent("Michał");
            this.SetName(student, "NewName");
            Assert.Equal("NewName", student.FirstName);
        }
        private Student GetStudent(string firstName)
        {
            return new Student(firstName);
        }
        private void SetName(Student student, string firstName)
        {
            student.FirstName = firstName;
        }
    }
}
