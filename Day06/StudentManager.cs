namespace OopDay6;

public class StudentManager
{
    private readonly IStudentService _studentService;

    // Composition: StudentManager "has-a" IStudentService, injected via constructor.
    // It depends on the IStudentService interface rather than a concrete implementation.
    public StudentManager(IStudentService studentService)
    {
        _studentService = studentService ?? throw new ArgumentNullException(nameof(studentService));
    }

    public void RegisterStudent(Student student)
    {
        _studentService.AddStudent(student);
        Console.WriteLine($"Student added: {student.Name}");
    }

    public void DisplayAllStudents()
    {
        var students = _studentService.GetAllStudents();
        Console.WriteLine("\nStudent Records:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine($"\nTotal students: {students.Count}");
    }

    public Student? FindStudent(int studentId)
    {
        return _studentService.GetStudentById(studentId);
    }
}
