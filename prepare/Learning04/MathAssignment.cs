public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbook, string problems) : base(studentName, topic)
    {
        _textbookSection = textbook;
        _problems = problems;
        
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic} \n{_textbookSection} {_problems}";
    }
}