public class Student
{
    public string Name { get; }
    public int Age { get; }

    public Student(string name, int age)
    {
        StudentValidator.Validate(name, age);
        Name = name;
        Age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
