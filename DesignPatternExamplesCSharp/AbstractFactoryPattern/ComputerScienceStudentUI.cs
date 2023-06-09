using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public class ComputerScienceStudentUI : IStudent
{
    public List<string> Courses()
    {
        return new List<string>{"Intro To ComputerScience", "Data Structures", "Algorithms", "Java" };
    }
}