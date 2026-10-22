
using System.Text.Json;

const string FilePath = "jobs.json";

var applications = LoadApplications();

while (true)
{
    Console.WriteLine("\n=== Job Application Tracker ===");
    Console.WriteLine("1. Add application");
    Console.WriteLine("2. View applications");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    try
    {
        switch (choice)
        {
            case "1":
                Console.Write("Company name: ");
                string? company = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(company))
                {
                    Console.WriteLine("Company name is required.");
                    break;
                }

                Console.Write("Job role: ");
                string? role = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(role))
                {
                    Console.WriteLine("Job role is required.");
                    break;
                }

                applications.Add(new JobApplication
                {
                    Company = company.Trim(),
                    Role = role.Trim(),
                    AppliedOn = DateTime.Today
                });

                SaveApplications(applications);
                Console.WriteLine("Application saved.");
                break;

            case "2":
                if (applications.Count == 0)
                {
                    Console.WriteLine("No applications found.");
                    break;
                }

                foreach (var app in applications)
                {
                    Console.WriteLine(
                        $"{app.Company} - {app.Role} - " +
                        $"{app.AppliedOn:yyyy-MM-dd}");
                }
                break;

            case "3":
                Console.WriteLine("Goodbye!");
                return;

            default:
                Console.WriteLine("Choose 1, 2, or 3.");
                break;
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine($"File operation failed: {ex.Message}");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("You don't have permission to access the file.");
    }
    finally
    {
        // This block runs after each attempted menu operation.
        // It is useful for cleanup or final logging.
    }
}

static List<JobApplication> LoadApplications()
{
    try
    {
        if (!File.Exists(FilePath))
            return new List<JobApplication>();

        string json = File.ReadAllText(FilePath);

        return JsonSerializer.Deserialize<List<JobApplication>>(json)
            ?? new List<JobApplication>();
    }
    catch (JsonException)
    {
        Console.WriteLine("The JSON file is invalid. Starting with an empty list.");
        return new List<JobApplication>();
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Could not read applications: {ex.Message}");
        return new List<JobApplication>();
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine("No permission to read the applications file.");
        return new List<JobApplication>();
    }
}

static void SaveApplications(List<JobApplication> applications)
{
    string json = JsonSerializer.Serialize(
        applications,
        new JsonSerializerOptions { WriteIndented = true });

    File.WriteAllText(FilePath, json);
}

public class JobApplication
{
    public string Company { get; set; } = "";
    public string Role { get; set; } = "";
    public DateTime AppliedOn { get; set; }
}
