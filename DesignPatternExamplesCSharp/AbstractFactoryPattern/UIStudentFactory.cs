using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public class UIStudentFactory : StudentFactory
{
    public override IStudent GetStudent(string studentDept)
    {
        if (studentDept.Equals("CS"))
            return new ComputerScienceStudentUI();
        if(studentDept.Equals("InfoSystems"))
            return new InformationSystemsStudentUI();
        return null;
    }
}