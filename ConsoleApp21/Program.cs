// See https://aka.ms/new-console-template for more information

using ConsoleApp21;

Student student1 = new Student("Tom",22,"Frontend Web Development","2024001");
Student student2 = new Student("Jazz",21,"Backend Web Development","2024002");

Subject subject1 = new Subject("JS001","Javascript",10);
Subject subject2 = new Subject("NJS01","NodeJS",10);

Grade grade1 = new Grade(student1,subject1,9);
Grade grade2 = new Grade(student2,subject2,10);
grade1.PrintGradeInfo();
grade2.PrintGradeInfo();