using System;

class Student
{
    // Properties
    public string Name;
    public int Age;
    public int Grade;


    // Constructor
    public Student(string name, int age, int grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }


    // Method
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
        Console.WriteLine();
    }
}