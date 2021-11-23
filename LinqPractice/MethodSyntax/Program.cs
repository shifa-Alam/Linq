using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodSyntax
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

            //LINQ Method Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));
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
                new Student { Id=5, Name="Jahid",Age=13},
                new Student { Id=6, Name="Masud",Age=19}
            };

            //LINQ Query for find Teenager Students

            var teenagerStudents = studentList.Where(s=>s.Age>12 && s.Age<20);

            foreach (var student in teenagerStudents)
            {

                Console.WriteLine(student.Name);
            }
        }
    }
}
