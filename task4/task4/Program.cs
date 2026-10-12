using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("===== Student Information =====");
        Console.WriteLine();


        // Creating Objects using Constructor

        Student student1 = new Student("Ahmad", 20, 85);

        Student student2 = new Student("Sara", 21, 92);

        Student student3 = new Student("Omar", 19, 78);



        // Calling Method

        student1.DisplayInfo();

        student2.DisplayInfo();

        student3.DisplayInfo();


        Console.ReadLine();
    }
}