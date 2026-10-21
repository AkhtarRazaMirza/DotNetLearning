namespace OopDay6;

public class AcademicStudentRecord : StudentRecord
{
    public string Major { get; }
    public double Gpa { get; }

    public AcademicStudentRecord(Student student, string major, double gpa)
        : base(student)
    {
        if (string.IsNullOrWhiteSpace(major))
            throw new ArgumentException("Major cannot be empty.", nameof(major));

        if (gpa < 0.0 || gpa > 4.0)
            throw new ArgumentOutOfRangeException(nameof(gpa), "GPA must be between 0.0 and 4.0.");

        Major = major;
        Gpa = gpa;
    }

    public override string RecordType => "Academic Record";

    public override string GetRecordDetails()
    {
        return $"Major: {Major} | GPA: {Gpa:F2}";
    }
}

public class CertificateStudentRecord : StudentRecord
{
    public string CourseName { get; }

    public CertificateStudentRecord(Student student, string courseName)
        : base(student)
    {
        if (string.IsNullOrWhiteSpace(courseName))
            throw new ArgumentException("Course name cannot be empty.", nameof(courseName));

        CourseName = courseName;
    }

    public override string RecordType => "Certificate Record";

    public override string GetRecordDetails()
    {
        return $"Certified in: {CourseName}";
    }
}
