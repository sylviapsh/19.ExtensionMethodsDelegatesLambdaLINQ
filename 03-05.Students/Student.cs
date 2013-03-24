using System.Linq;
using System.Text;

namespace Students
{
    public class Student
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public Student[] StudentArray { get; set; }

        //Constructor
        public Student(string firstName, string lastName) : this(firstName, lastName, null) { }

        public Student(string firstName, string lastName, int? age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Method that finds all students whose first name is before its last name alphabetically
        public static string FirstBeforeLastName(Student[] studentsArr)
        {
            var resultStudentsArr =
                from student in studentsArr
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            StringBuilder foundStudents = new StringBuilder();
            foreach (var foundStudent in resultStudentsArr)
            {
                foundStudents.Append(foundStudent.FirstName);
                foundStudents.Append(" ");
                foundStudents.AppendLine(foundStudent.LastName);
            }

            return foundStudents.ToString();
        }
    }

    
}
