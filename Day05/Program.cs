using OopDay5;

Student student = new Student(1, "Akhtar", 20);
Course course = new Course(101, "C# Fundamentals", 30);

JobApplication application = new JobApplication(
    1,
    "Example Company",
    "Junior .NET Developer"
);

student.Display();
course.Display();
application.Display();

application.UpdateStatus("Interview");

Console.WriteLine("\nAfter updating application:");
application.Display();