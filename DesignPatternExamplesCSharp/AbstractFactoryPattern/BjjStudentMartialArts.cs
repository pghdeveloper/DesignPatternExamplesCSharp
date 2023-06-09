using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public class BjjStudentMartialArts : IStudent
{
    public List<string> Courses()
    {
        return new List<string>{"Intro To Bjj", "Fundamentals", "Advanced", "Competition"};
    }
}