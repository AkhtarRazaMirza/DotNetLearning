namespace OopDay5;

public class JobApplication
{
    public int Id { get; }
    public string CompanyName { get; }
    public string Position { get; }
    public string Status { get; private set; }

    public JobApplication(int id, string companyName, string position)
    {
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id));

        if (string.IsNullOrWhiteSpace(companyName))
            throw new ArgumentException("Company name is required.");

        if (string.IsNullOrWhiteSpace(position))
            throw new ArgumentException("Position is required.");

        Id = id;
        CompanyName = companyName;
        Position = position;
        Status = "Applied";
    }

    public void UpdateStatus(string newStatus)
    {
        if (string.IsNullOrWhiteSpace(newStatus))
            throw new ArgumentException("Status is required.");

        Status = newStatus;
    }

    public void Display()
    {
        Console.WriteLine(
            $"{CompanyName} | {Position} | {Status}"
        );
    }
}