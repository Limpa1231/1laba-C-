using System;

namespace lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { Age = 21, Id = 143, GroupNumber = 24, Name = "Симсон"};
            Student student2 = new Student() { Age = 27, Id = 325, GroupNumber = 32, Name = "Леви"};

            student1.Add(student2);
            student2.AddThree(student1, student2);
            Console.WriteLine("Student1:");
            Console.WriteLine($"Id = {student1.Id}, Age = {student1.Age}, Name = {student1.Name}, GroupNumber = {student1.GroupNumber}");
            Console.WriteLine("Student2:");
            Console.WriteLine($"Id = {student2.Id}, Age = {student2.Age}, Name = {student2.Name}, GroupNumber = {student2.GroupNumber}");
        }
    }
}
