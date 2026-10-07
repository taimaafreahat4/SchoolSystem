using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1 – Enter Student Information
            Console.Write("Enter student Name:");
            string studentName = Console.ReadLine();


            Console.Write("Enter student Age:");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student Grade:");
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student Average:");
            double studentAverage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Student Gender: ");
            char studentGender = Convert.ToChar(Console.ReadLine());


            // Part 2 – Student Report

            Console.WriteLine();
            Console.WriteLine("===== Student Report =====");

            Console.WriteLine();
            Console.WriteLine($"Welcome {studentName}!");
            Console.WriteLine();

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Average: {studentAverage}");
            Console.WriteLine($"Gender: {studentGender}");


            // Part 3 – Student Name

            Console.WriteLine();
            Console.WriteLine("===== Name Information =====");

            Console.WriteLine();
            Console.WriteLine($"Original Name: {studentName}");
            Console.WriteLine($"Uppercase: {studentName.ToUpper()}");
            Console.WriteLine($"Lowercase: {studentName.ToLower()}");
            Console.WriteLine($"First Character: {studentName[0]}");


            // Part 4 – Simple Student Calculation

            double newAverage = studentAverage + 5;

            Console.WriteLine();
            Console.WriteLine("===== Student Calculation =====");

            Console.WriteLine();
            Console.WriteLine($"Original Average: {studentAverage}");
            Console.WriteLine("Bonus Marks: 5");
            Console.WriteLine($"New Average: {newAverage}");



            // Part 5 – Student Status
            // ==============================

            bool passed = newAverage >= 50;
            bool adult = studentAge >= 18;

            Console.WriteLine();
            Console.WriteLine("===== Student Status =====");

            Console.WriteLine();
            Console.WriteLine($"New Average: {newAverage}");
            Console.WriteLine($"Passed: {passed}");
            Console.WriteLine($"Adult: {adult}");

            Console.WriteLine();
            if (passed)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }

            // Final Student Summary
            // ==============================

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("        STUDENT SUMMARY");
            Console.WriteLine("================================");

            Console.WriteLine();
            Console.WriteLine($"Welcome {studentName.ToUpper()}!");
            Console.WriteLine();

            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Average: {studentAverage}");
            Console.WriteLine($"New Average: {newAverage}");
            Console.WriteLine($"Gender: {studentGender}");

            Console.WriteLine();
            Console.WriteLine($"Result: {(passed ? "Passed" : "Failed")}");
            Console.WriteLine($"Adult: {adult}");

            Console.WriteLine();
            Console.WriteLine("================================");
        }
    }
}

    

