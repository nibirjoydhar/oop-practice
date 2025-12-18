public class Student
{
    public string Name;
    public int Age;

    public void Print()
    {
        if (string.IsNullOrEmpty(Name))
        {
            System.Console.WriteLine("Invalid name");
        }

        System.Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
