using System;
class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;

    }
    class Student : Person
    {
        public String StudentId;
        public Student(string name, int age, String studentId) : base(name, age)
        {
            StudentId = studentId;
        }
        public void Display()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Student ID:" + StudentId);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ramisa", 21, "25-61084-1");
            s.Display();
        }
    }
}