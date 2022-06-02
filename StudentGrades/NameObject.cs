using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrades
{
    public class NameObject
    {
        private string firstName;
        public NameObject(string firstName)
        {
            this.firstName = firstName;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.firstName = value;
                }
            }
        }
    }
}
