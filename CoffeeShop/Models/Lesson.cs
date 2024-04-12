public class Question
{
    public int Id { get; set; }
    public string Text { get; set; }
    public List<Answer> Answers { get; set; }
}

public class Answer
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
}

public class Question2
{
    public int Id2 { get; set; }
    public string Text2 { get; set; }
    public List<Answer2> Answers2 { get; set; }
}

public class Answer2
{
    public int Id2 { get; set; }
    public string Text2 { get; set; }
    public bool IsCorrect2 { get; set; }
}

public class Question3
{
    public int Id3 { get; set; }
    public string Text3 { get; set; }
    public List<Answer3> Answers3 { get; set; }
}

public class Answer3
{
    public int Id3 { get; set; }
    public string Text3 { get; set; }
    public bool IsCorrect3 { get; set; }
}

public class QuestionF
{
    public int IdF { get; set; }
    public string TextF { get; set; }
    public List<AnswerF> AnswersF { get; set; }
}

public class AnswerF
{
    public int IdF { get; set; }
    public string TextF { get; set; }
    public bool IsCorrectF { get; set; }
}