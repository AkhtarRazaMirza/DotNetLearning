namespace OopDay6;

public class InMemoryStudentService : IStudentService
{
    private readonly List<Student> _students = new();

    public void AddStudent(Student student)
    {
        ArgumentNullException.ThrowIfNull(student);

        if (_students.Any(s => s.StudentId == student.StudentId))
        {
            throw new InvalidOperationException($"Student with ID {student.StudentId} already exists.");
        }

        _students.Add(student);
    }

    public IReadOnlyList<Student> GetAllStudents()
    {
        return _students.AsReadOnly();
    }

    public Student? GetStudentById(int studentId)
    {
        return _students.FirstOrDefault(s => s.StudentId == studentId);
    }
}
