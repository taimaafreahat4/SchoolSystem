using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1 - Student Information

            string studentName = "Sami Ali";
            int studentAge = 20;
            int studentGrade = 12;
            double studentAverage = 85.5;
            char studentGender = 'M';
            bool isStudentActive = true;


            Console.WriteLine("===== Student Information =====");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine("Active: " + isStudentActive);
            // Part 2 - Multiple Students
            string[] students =
            {
                "Ahmad","taimaa","rana","osama"
            };
            Console.WriteLine("\n===== Students =====");
            Console.WriteLine("student 1:" + students[0]);

            Console.WriteLine("student 2:" + students[1]);

            Console.WriteLine("student 3:" + students[2]);

            Console.WriteLine("student 4:" + students[3]);


            Console.WriteLine("\nNumber of Students: " + students.Length);


            // Part 3 - Access and Change Array Elements


            Console.WriteLine("\n===== Before Change =====");

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);


            // Change student name

            students[2] = "Khaled";
            Console.WriteLine("\n===== After Change =====");

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);


            // Access first and last student
            Console.WriteLine("\n===== First and Last Student =====");
            Console.WriteLine("First Student:" + students[0]);
            Console.WriteLine("Last Student:" + students[students.Length -1]);



        }
    }
}
