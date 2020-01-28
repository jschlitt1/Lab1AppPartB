using System;

namespace Lab1AppPartB
{
    class PartB
    {
        static void Main(string[] args)
        {
            bool run = true;
            int input;

            while (run)
            {
                Console.WriteLine("Please enter a 1.)Student, 2.)Teacher, 3.)End");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:Console.WriteLine("Student");
                        break;
                    case 2:
                        Console.WriteLine("Teacher");
                        break;
                    default:
                        run = false;
                        break;
                }
            }
        }
    }
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String ID { get; set; }
        public Program Program { get; set; }
        public Person(String name, int age, String id, Program program)
        {
            Name = name;
            Age = age;
            ID = id;
            Program = program;
        }
    }
    public class Student: Person
    {
        public int Credits { get; set; }
        public Student(String name, int age, String id, Program program, int credits)
        {
            Name = name;
            Age = age;
            ID = id;
            Program = program;
            Credits = credits;
        }
    }
    public class Teacher: Person
    {
        public int Years { get; set; }
        public Teacher(String name, int age, String id, Program program, int years)
        {
            Name = name;
            Age = age;
            ID = id;
            Program = program;
            Years = years;
        }
    }
    
    public enum Program
    {
        ComputerScience,
        Accounting,
        Marketing,
        Nursing
    }
}
