using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemTask
{
        public class Student : Person
        {
            public int Grade { get; set; }

            // Public property
            public string StudentId { get; set; }

            public Student(
                string name,
                int age,
                string schoolName,
                int grade,
                string studentId
                )
                :base(name,age,schoolName)
            {
                Grade = grade;
                StudentId= studentId;
            }
            public void DisplayStudentInfo()
            {
                DisplayInfo();
                Console.WriteLine($"School: {SchoolName}");
                Console.WriteLine($"Grade: {Grade}");
                Console.WriteLine($"Student ID: {StudentId}");
            }
        }
    }

