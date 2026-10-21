namespace OopDay6;

public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty or whitespace.", nameof(name));

        Name = name;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}.");
    }
}
