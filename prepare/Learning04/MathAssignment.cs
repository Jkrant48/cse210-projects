

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problems, string studentName, string topic) : base(studentName, topic)
    {
        _problems = problems;
        _textbookSection = textbookSection;
    }


    public string GetHomeWorkList()
    {

        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}