// See https://aka.ms/new-console-template for more information

using AbstractFactoryPattern;
using AbstractFactoryPattern.Interfaces;

IStudent student = null;
StudentFactory studentFactory = null;
List<string> courses = null;
            
//create a UI student factory by passing the factory type as UI
studentFactory = StudentFactory.CreateStudentFactory("UI");
Console.WriteLine("Student School: "+ studentFactory.GetType().Name);

// get bio student by passing the student type. 
student = studentFactory.GetStudent("CS");
Console.WriteLine("Student Dept: "+ student.GetType().Name);
courses = student.Courses();
foreach (var item in courses)
{
    Console.WriteLine("Course code: "+ item);
}
Console.WriteLine();

Console.WriteLine("------------------------------");

Console.ReadLine();