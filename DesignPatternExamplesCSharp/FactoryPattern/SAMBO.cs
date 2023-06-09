using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class SAMBO : IFactory
{
    public decimal CalculatePrice()
    {
        return 1000 + 3;
    }
}