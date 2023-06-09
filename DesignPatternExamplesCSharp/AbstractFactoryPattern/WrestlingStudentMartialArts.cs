using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public class WrestlingStudentMartialArts : IStudent
{
    public List<string> Courses()
    {
        return new List<string>{"Intro To Wrestling", "Fundamentals", "Advanced", "Competition"};
    }
}