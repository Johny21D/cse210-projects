public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // _studentName is private in base, so we use the public getter
        return $"{_title} by {GetStudentName()}";
    }
}