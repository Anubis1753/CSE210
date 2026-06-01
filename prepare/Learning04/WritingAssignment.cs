public class WritingAssignments : Assignment
{
    private string _title;

    public WritingAssignments(string studentName, string topic, string title)
        :base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}