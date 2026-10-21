namespace OopDay6;

public class Student : Person
{
    public int StudentId { get; }

    public Student(int studentId, string name) : base(name)
    {
        if (studentId <= 0)
            throw new ArgumentOutOfRangeException(nameof(studentId), "Student ID must be greater than zero.");

        StudentId = studentId;
    }

    public override void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}, and my Student ID is {StudentId}.");
    }

    public override string ToString()
    {
        return $"ID: {StudentId} | Name: {Name}";
    }
}
