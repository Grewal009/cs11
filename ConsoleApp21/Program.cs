// See https://aka.ms/new-console-template for more information

using ConsoleApp21;

Student student1 = new Student("Tom",22,"Frontend Web Development","2024001");
Student student2 = new Student("Jazz",21,"Backend Web Development","2024002");

Subject subject1 = new Subject("JS001","Javascript",10);
Subject subject2 = new Subject("NJS01","NodeJS",10);
Subject subject3 = new Subject("FL001","React",10);

Grade grade1 = new Grade(student1,subject1,9);
Grade grade2 = new Grade(student1,subject2,10);
Grade grade3 = new Grade(student1,subject2,9);

/*grade1.PrintGradeInfo();
grade2.PrintGradeInfo();*/

student1.AddSubject(subject1);
student1.AddSubject(subject2);
student1.AddSubject(subject3);

student1.AddGrade(grade1);
student1.AddGrade(grade2);
student1.AddGrade(grade3);

Console.WriteLine("\n*** Student Info: ***");
student1.PrintStudentInfo();
Console.WriteLine("\n*** Subjects: ***");
student1.ShowAllSubjects();
Console.WriteLine("\n*** Grades: ***");
student1.ShowAllGrades();

Console.WriteLine($"⭐⭐️️⭐️️  Final Result:  {student1.GetAverage():F1} / {student1.GetTotalStudyPoints()}  ⭐️️️⭐️️⭐️️");
