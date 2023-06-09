using System.Threading.Tasks.Dataflow;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern;

public class MartialArtsStudentFactory : StudentFactory
{
    public override IStudent GetStudent(string studentDept)
    {
        if (studentDept.Equals("BJJ"))
            return new BjjStudentMartialArts();
        if(studentDept.Equals("Judo"))
            return new JudoStudentMartialArts();
        if(studentDept.Equals("Wrestling"))
            return new WrestlingStudentMartialArts();
        return null;
    }
}