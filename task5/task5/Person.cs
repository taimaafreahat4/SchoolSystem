using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemTask
{
     public class Person
    {
        public string Name;
        public int Age { get; set; }
        protected string SchoolName { get; set; }

        private string _internalCode;
        public Person(string name,int age,string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
