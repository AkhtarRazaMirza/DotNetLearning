var applications = new List<JobApplication>
{
    new()
    {
        Company = "TechCorp",
        Position = "Backend Developer",
        Status = "Interview",
        Salary = 600000
    },
    new()
    {
        Company = "WebWorks",
        Position = "Frontend Developer",
        Status = "Applied",
        Salary = 450000
    },
    new()
    {
        Company = "CloudTech",
        Position = ".NET Developer",
        Status = "Interview",
        Salary = 700000
    },
    new()
    {
        Company = "StartUp",
        Position = "Junior Developer",
        Status = "Rejected",
        Salary = 300000
    },
    new()
    {
        Company = "DataCorp",
        Position = "Full Stack Developer",
        Status = "Applied",
        Salary = 500000
    }
};

// 1. Overall statistics
Console.WriteLine("=== APPLICATION SUMMARY ===");

Console.WriteLine($"Total: {applications.Count()}");

Console.WriteLine(
    $"Interview stage: {applications.Count(a => a.Status == "Interview")}");

Console.WriteLine(
    $"Applied stage: {applications.Count(a => a.Status == "Applied")}");

Console.WriteLine(
    $"Rejected stage: {applications.Count(a => a.Status == "Rejected")}");

// 2. Applications with salary >= ₹500,000
Console.WriteLine("\n=== HIGH-SALARY APPLICATIONS ===");

var highSalary = applications
    .Where(a => a.Salary >= 500000)
    .OrderByDescending(a => a.Salary)
    .Select(a => new
    {
        a.Company,
        a.Position,
        a.Salary
    });

foreach (var app in highSalary)
{
    Console.WriteLine(
        $"{app.Company} | {app.Position} | ₹{app.Salary:N0}");
}

// 3. Group applications by status
Console.WriteLine("\n=== STATUS REPORT ===");

var statusGroups = applications.GroupBy(a => a.Status);

foreach (var group in statusGroups)
{
    Console.WriteLine($"\n{group.Key}:");

    foreach (var app in group)
    {
        Console.WriteLine($"  - {app.Company} ({app.Position})");
    }
}

// 4. Highest salary
var highest = applications
    .OrderByDescending(a => a.Salary)
    .FirstOrDefault();

if (highest is not null)
{
    Console.WriteLine(
        $"\nHighest: {highest.Company} — ₹{highest.Salary:N0}");
}
