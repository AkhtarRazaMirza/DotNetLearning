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
    }
};

// Initial verification
var interviews = applications
    .Where(app => app.Status == "Interview")
    .ToList();

var highestPaying = applications
    .OrderByDescending(app => app.Salary)
    .ToList();

foreach (var app in interviews)
{
    Console.WriteLine($"{app.Company}: {app.Position}");
}

Console.WriteLine("\nHighest-paying applications:");

foreach (var app in highestPaying)
{
    Console.WriteLine($"{app.Company}: ₹{app.Salary:N0}");
}

// ---------------------------------------------------------
// EXTENSIONS
// ---------------------------------------------------------

// 1. Generic method that accepts a list and returns its count
Console.WriteLine("\n--- Generic Method (GetCount<T>) ---");
Console.WriteLine($"Total applications: {GetCount(applications)}");
Console.WriteLine($"Interview applications: {GetCount(interviews)}");

// 2. Lambda to find applications offering at least ₹500,000
Console.WriteLine("\n--- Applications Offering At Least ₹500,000 ---");
var highPaying = applications
    .Where(app => app.Salary >= 500000)
    .ToList();

foreach (var app in highPaying)
{
    Console.WriteLine($"{app.Company} ({app.Position}): ₹{app.Salary:N0}");
}
Console.WriteLine($"Count of high-paying applications: {GetCount(highPaying)}");

// 3. Sort applications alphabetically by company name
Console.WriteLine("\n--- Applications Sorted Alphabetically by Company Name ---");
var sortedByCompany = applications
    .OrderBy(app => app.Company)
    .ToList();

foreach (var app in sortedByCompany)
{
    Console.WriteLine($"{app.Company} | {app.Position} | ₹{app.Salary:N0} | {app.Status}");
}

// 4. Extension method that checks whether an application has a particular status
Console.WriteLine("\n--- Extension Method (HasStatus) ---");
Console.WriteLine($"TechCorp status is Interview? {applications[0].HasStatus("Interview")}");
Console.WriteLine($"TechCorp status is Rejected? {applications[0].HasStatus("Rejected")}");

// Using the extension method in a LINQ query
var interviewUsingExtension = applications
    .Where(app => app.HasStatus("Interview"))
    .ToList();

Console.WriteLine($"Applications with status 'Interview' found via extension method: {GetCount(interviewUsingExtension)}");
foreach (var app in interviewUsingExtension)
{
    Console.WriteLine($"- {app.Company}: {app.Position}");
}

// Generic method that accepts a list and returns its count
static int GetCount<T>(List<T> list)
{
    return list.Count;
}
