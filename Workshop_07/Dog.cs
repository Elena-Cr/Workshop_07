namespace workshop_07;

public class Dog : Animal
{
    public string? Breed { get; set; }
    public void PrintBreed()
    {
        Console.WriteLine($"This dog is a {Breed}.");
    }
}