using StudentGrades;
using Xunit;

namespace Tests
{
    public class TypeTests
    {
        public delegate string WriteMessage(string message);
        int counter;
        [Fact]
        public void WriteMessageDelegateCanPointToMethod()
        {
            WriteMessage del = ReturnMessage;
            del += ReturnMessage;
            del += ReturnMessage2;
            var result = del("hey!");
            Assert.Equal(3, counter);
        }
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
        private string ReturnMessage(string message)
        {
            counter++;
            return message;
        }
        private string ReturnMessage2(string message)
        {
            counter++;
            return message.ToUpper();
        }
    }
}
