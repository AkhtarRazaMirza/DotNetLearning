namespace OopDay5;

public class Course
{
    public int Id { get; }
    public string Title { get; }
    public int DurationInDays { get; }

    public Course(int id, string title, int durationInDays)
    {
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id));

        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title is required.");

        if (durationInDays <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(durationInDays)
            );

        Id = id;
        Title = title;
        DurationInDays = durationInDays;
    }

    public void Display()
    {
        Console.WriteLine(
            $"Course: {Title}, Duration: {DurationInDays} days"
        );
    }
}