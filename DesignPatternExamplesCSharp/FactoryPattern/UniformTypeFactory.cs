using FactoryPattern.Interfaces;

namespace FactoryPattern;

public abstract class UniformTypeFactory
{
    public abstract IFactory GetUniformType(string uniformType);
}