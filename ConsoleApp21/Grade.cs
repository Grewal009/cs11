namespace ConsoleApp21;

public class Grade
{
    public Student student { get; private set; }
    public Subject subject { get; private set; }
    public double GradePoints { get; private set; }

    public Grade(Student student, Subject subject, double gradePoints)
    {
        this.student = student;
        this.subject = subject;
        GradePoints = gradePoints;
    }

    public void PrintGradeInfo()
    {
        Console.WriteLine("Grade Info:");
        Console.WriteLine($"Student Id:{student.StudentId}, Subject Id:{subject.SubjectId}, Result:{GradePoints}");
    }
}