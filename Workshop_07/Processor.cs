namespace workshop_07;

public class Processor
{
    public void Process()
    {
        Dog d = new Dog();
        d.Breed = "German Shepherd";
        d.PrintBreed();
        d.Age = 5;
        d.PrintAge();
    }
}