namespace ConsoleApp21;

public class Student
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Course { get; private set; }
    public string StudentId { get; private set; }

    public List<Subject> SubjectList { get; private set; } =
        new List<Subject>();

    public List<Grade> GradeList { get; private set; } = new List<Grade>();

    public Student(string name, int age, string course, string studentId)
    {
        Name = name;
        Age = age;
        Course = course;
        StudentId = studentId;
    }

    public void AddSubject(Subject subject)
    {
        SubjectList.Add(subject);
    }

    public void AddGrade(Grade grade)
    {
        GradeList.Add(grade);
    }

    public double GetAverage()
    {
        double sum = 0;
        if (GradeList.Count == 0)
        {
            Console.WriteLine("No record found in grade card");
            return 0;
        }

        foreach (var grade in GradeList)
        {
            sum += grade.GradePoints;
        }

        return sum / GradeList.Count;
    }

    public double GetTotalStudyPoints()
    {
        double sum = 0;
        if (SubjectList.Count == 0)
        {
            Console.WriteLine("No subject found");
            return 0;
        }

        foreach (var subject in SubjectList)
        {
            sum += subject.SubjectPoints;
        }

        return sum;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine("Student Info:");
        Console.WriteLine(
            $"Name:{Name}, Age:{Age}, Course:{Course}, StudentId:{StudentId}");
    }
}