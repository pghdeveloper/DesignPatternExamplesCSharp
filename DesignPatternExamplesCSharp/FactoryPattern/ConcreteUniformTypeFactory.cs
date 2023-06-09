using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class ConcreteUniformTypeFactory : UniformTypeFactory
{
    public override IFactory GetUniformType(string uniformType)
    {
        switch (uniformType)
        {
            case "BOP":
                return new GI();
            case "GL":
                return new NOGI();
            case "PL":
                return new SAMBO();
            default:
                throw new ApplicationException(string.Format("Uniform Type '{0}' cannot be created", uniformType));
        }
    }

}