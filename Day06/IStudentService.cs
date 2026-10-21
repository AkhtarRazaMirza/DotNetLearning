namespace OopDay6;

public interface IStudentService
{
    void AddStudent(Student student);
    IReadOnlyList<Student> GetAllStudents();
    Student? GetStudentById(int studentId);
}
