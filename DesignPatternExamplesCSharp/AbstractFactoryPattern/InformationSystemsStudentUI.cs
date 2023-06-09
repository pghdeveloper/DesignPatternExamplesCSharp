using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public class InformationSystemsStudentUI : IStudent
{
    public List<string> Courses()
    {
        return new List<string>{"Intro To Info Systems", "Networking Concepts", "Intro To Programming", "Systems Analysis"};
    }
}