using System;
using System.Linq;

namespace Students
{
    class StudentsTest
    {
        static void Main()
        {
            //Students array declaration
            Student[] studentsArray = {
                                          new Student("Ivan", "Ivanov"),
                                          new Student("Kalinka", "Ivanova"),
                                          new Student("Peter", "Petrov"),
                                          new Student("Ivan", "Dojnov"),
                                      };

            //Task 3: Test the method that finds all students whose first name is before its last name alphabetically
            Console.WriteLine("List of students whose first name is before its last name alphabetically:");
            Console.WriteLine(Student.FirstBeforeLastName(studentsArray));

            //Students array declaration with age
            Student[] studentsArray2 = {
                                          new Student("Ivan", "Ivanov", 20),
                                          new Student("Kalinka", "Ivanova", 13),
                                          new Student("Peter", "Petrov", 18),
                                          new Student("Ivan", "Dojnov", 25),
                                      };

            //Task 4: Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            var resultStudent =
                from student in studentsArray2
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("List of students with age between 18 and 24:");
            foreach (var foundStudent in resultStudent)
            {
                Console.WriteLine("{0} {1} age: {2}", foundStudent.FirstName, foundStudent.LastName, foundStudent.Age);
            }

            //Task 5: Sort the students by first name and last name in descending order with lambda expressions

            var sortedStudents = studentsArray2.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            Console.WriteLine();
            Console.WriteLine("List of students sorted in descending order by name with lambda expression: ");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            //Task 5: Sort the students by first name and last name in descending order with LINQ
            var sortedStudentsLINQ =
                from student in studentsArray2
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine();
            Console.WriteLine("List of students sorted in descending order by name with LINQ: ");
            foreach (var student in sortedStudentsLINQ)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
