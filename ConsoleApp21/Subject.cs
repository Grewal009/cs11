namespace ConsoleApp21;

public class Subject
{
    public string SubjectId { get; private set; }
    public string SubjectName { get; private set; }
    public int SubjectPoints { get; private set; }

    public Subject(string subjectId, string subjectName, int subjectPoints)
    {
        SubjectId = subjectId;
        SubjectName = subjectName;
        SubjectPoints = subjectPoints;
    }

    public void PrintSubjectInfo()
    {
        Console.WriteLine("Subject Info:");
        Console.WriteLine($"Subject Id:{SubjectId}, Subject Name:{SubjectName}, Subject Points:{SubjectPoints}");
    }
}