
using System;

namespace SchoolSystemTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== STUDENT 1 =====");

            Student student1 = new Student(
                "Ahmad", 15, "Al Noor School", 10, "S101");

            student1.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("===== STUDENT 2 =====");

            Student student2 = new Student(
                "Sara", 14, "Al Noor School", 9, "S102");

            student2.DisplayStudentInfo();

            Console.WriteLine();

            Console.WriteLine("===== TEACHER =====");

            Teacher teacher = new Teacher(
                "Mona", 32, "Al Noor School", "English");

            teacher.DisplayTeacherInfo();

            Console.WriteLine();

            Console.WriteLine("===== SCHOOL REPORT =====");

            SchoolReport report =
                new SchoolReport("Final Exam Report");

            report.DisplayReportTitle();

            Console.WriteLine();

            // ERROR: SchoolName is protected.
            // It cannot be accessed directly from Main().
            // Console.WriteLine(student1.SchoolName);

            // ERROR: _internalCode is private inside Person.
            // It cannot be accessed directly from Main().
            // Console.WriteLine(student1._internalCode);

            // ERROR: SchoolReport is sealed.
            // Another class cannot inherit from it.
            // class SpecialReport : SchoolReport { }

            Console.WriteLine("Program finished successfully!");
        }
    }
}
