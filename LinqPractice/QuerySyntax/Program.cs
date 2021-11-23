using System;
using System.Collections.Generic;
using System.Linq;

namespace QuerySyntax
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string collection 
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java",
                "Python"
            };

            //LINQ Query Syntax
            var result = from s in stringList where s.Contains("Tutorials") select s;
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }


            // Student Collection

            IList<Student> studentList = new List<Student> {
                new Student { Id=1, Name="Shifa",Age=20},
                new Student { Id=2, Name="Milon",Age=29},
                new Student { Id=3, Name="Shaharia",Age=22},
                new Student { Id=4, Name="Asif",Age=30},
                new Student { Id=5, Name="Jahid",Age=32},
                new Student { Id=6, Name="Masud",Age=19}
            };

            //LINQ Query for find Teenager Students

            var teenagerStudents = from student in studentList where student.Age > 12 && student.Age < 20 select student;

            foreach (var student in teenagerStudents)
            {

                Console.WriteLine(student.Name);
            }
        }
    }
}
