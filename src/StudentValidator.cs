public class StudentValidator
{
    public static void Validate(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty");

        if (age <= 0)
            throw new ArgumentException("Age must be positive");
    }
}
