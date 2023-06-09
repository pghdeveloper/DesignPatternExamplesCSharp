using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public class JudoStudentMartialArts : IStudent
{
    public List<string> Courses()
    {
        return new List<string> { "Intro To Judo", "Fundamentals", "Advanced", "Competition" };
    }
}