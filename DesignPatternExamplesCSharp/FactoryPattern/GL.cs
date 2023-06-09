using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class GL : IFactory
{
    public decimal CalculatePremium()
    {
        return 1000 + 2;
    }
}