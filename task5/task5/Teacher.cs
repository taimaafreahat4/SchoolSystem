
using System;

namespace SchoolSystemTask
{
    public class Teacher : Person
    {
        // Public auto-implemented property
        public string Subject { get; set; }

        public Teacher(
            string name,
            int age,
            string schoolName,
            string subject)
            : base(name, age, schoolName)
        {
            Subject = subject;
        }

        public void DisplayTeacherInfo()
        {
            DisplayInfo();

            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"School: {SchoolName}");
        }
    }
}
