namespace workshop_07;

public class Animal
{
    public string age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Animal Eats");
    }

    public void PrintAge()
    {
        Console.WriteLine($"This animal is {age} years old.");
    }
}