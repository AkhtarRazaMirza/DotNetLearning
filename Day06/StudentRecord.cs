namespace OopDay6;

public abstract class StudentRecord
{
    public Student Student { get; }
    public DateTime IssuedDate { get; }

    protected StudentRecord(Student student)
    {
        Student = student ?? throw new ArgumentNullException(nameof(student));
        IssuedDate = DateTime.Now;
    }

    // Abstract members: derived classes MUST implement these.
    public abstract string RecordType { get; }
    public abstract string GetRecordDetails();

    // Concrete method utilizing the abstract members (polymorphic template behavior)
    public virtual void PrintRecord()
    {
        Console.WriteLine($"[{RecordType}] {Student.Name} (ID: {Student.StudentId}) -> {GetRecordDetails()}");
    }
}
