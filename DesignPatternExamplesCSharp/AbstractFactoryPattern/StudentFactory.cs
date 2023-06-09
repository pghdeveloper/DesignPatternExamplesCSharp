using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public abstract class StudentFactory
{
    public abstract IStudent GetStudent(string studentDept);

    public static StudentFactory CreateStudentFactory(string studentSch)
    {
        if(studentSch.Equals("UI"))
            return new UIStudentFactory();
        else
            return new MartialArtsStudentFactory();
    }
}