namespace OopDay5;

public class Student
{
    public int Id { get; }
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Student(int id, string name, int age)
    {
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id));

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required.", nameof(name));

        Id = id;
        Name = name;
        ChangeAge(age);
    }

    public void ChangeAge(int newAge)
    {
        if (newAge < 1 || newAge > 120)
            throw new ArgumentOutOfRangeException(nameof(newAge));

        Age = newAge;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
    }
}