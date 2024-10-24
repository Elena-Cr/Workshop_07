namespace workshop_07;

public class Animal
{
    public int? Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Animal Eats");
    }

    public void PrintAge()
    {
        Console.WriteLine($"This animal is {Age} years old.");
    }
}