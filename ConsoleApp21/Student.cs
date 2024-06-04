namespace ConsoleApp21;

public class Student
{
    public string Name { get; private set; }
    public string Age { get; private set; }
    public string Course { get; private set; }
    public string StudentId { get; private set; }

    public Student(string name, string age, string course, string studentId)
    {
        Name = name;
        Age = age;
        Course = course;
        StudentId = studentId;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student Info:");
        Console.WriteLine($"Name:{Name}, Age:{Age}, Course:{Course}, StudentId:{StudentId}");   
    }
}