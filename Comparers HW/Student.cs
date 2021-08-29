using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers_HW
{
    class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public int CompareTo(Student other)
        {
            if (LastName.CompareTo(other.LastName) == 0)
            {
                if (FirstName.CompareTo(other.FirstName) != 0)
                    return Grade.CompareTo(other.Grade);
            }

            if (LastName.CompareTo(other.LastName) != 0)
                return Grade.CompareTo(other.Grade);

            return Grade.CompareTo(other.Grade);
        }

        public override string ToString()
        {
            return $"\"{FirstName}\" \"{LastName}\" Grade: {Grade}";
        }
    }
}
