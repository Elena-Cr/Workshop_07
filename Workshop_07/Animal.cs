namespace workshop_07;

public class Animal
{
    public string? Age { get; set; }

    public static void Eat()
    {
        Console.WriteLine("Animal Eats");
    }

    public void PrintAge()
    {
        Console.WriteLine($"This animal is {Age} years old.");
    }
}