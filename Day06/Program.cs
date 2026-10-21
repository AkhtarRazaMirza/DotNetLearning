using OopDay6;

Console.WriteLine("=== Student Management System ===\n");

// 1. Create interface implementation and inject into StudentManager (Composition)
IStudentService studentService = new InMemoryStudentService();
StudentManager studentManager = new StudentManager(studentService);

// 2. Create at least two student objects (Inherits from Person)
Student akhtar = new Student(101, "Akhtar");
Student rahul = new Student(102, "Rahul");

// 3. Add students through StudentManager (which delegates to IStudentService)
studentManager.RegisterStudent(akhtar);
studentManager.RegisterStudent(rahul);

// 4. Retrieve and display student records via StudentManager
studentManager.DisplayAllStudents();

// 5. Demonstrate Inheritance & Polymorphism with Person base class
Console.WriteLine("\n--- Demonstrating Inheritance & Polymorphism (Person base class) ---");
List<Person> people = new()
{
    new Person("General Person"),
    akhtar, // Student treated polymorphically as Person
    rahul
};

foreach (Person person in people)
{
    // Runtime polymorphism invokes the overridden Introduce() on Student instances
    person.Introduce();
}

// 6. Demonstrate Abstract Class and Concrete Implementations (StudentRecord)
Console.WriteLine("\n--- Demonstrating Abstract Class (StudentRecord) ---");
List<StudentRecord> records = new()
{
    new AcademicStudentRecord(akhtar, "Computer Science", 3.85),
    new CertificateStudentRecord(rahul, "ASP.NET Core & C# Mastery")
};

foreach (StudentRecord record in records)
{
    // Polymorphic call to PrintRecord() which invokes the derived class implementation
    record.PrintRecord();
}
