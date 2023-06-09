using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class ConcreteApplicationTypeFactory : ApplicationTypeFactory
{
    public override IFactory GetApplicationType(string applicationType)
    {
        switch (applicationType)
        {
            case "BOP":
                return new BOP();
            case "GL":
                return new GL();
            case "PL":
                return new PL();
            default:
                throw new ApplicationException(string.Format("ApplicationType '{0}' cannot be created", applicationType));
        }
    }

}