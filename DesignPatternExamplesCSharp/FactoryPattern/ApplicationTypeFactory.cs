using FactoryPattern.Interfaces;

namespace FactoryPattern;

public abstract class ApplicationTypeFactory
{
    public abstract IFactory GetApplicationType(string applicationType);
}