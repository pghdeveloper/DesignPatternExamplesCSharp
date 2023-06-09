using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class PL : IFactory
{
    public decimal CalculatePremium()
    {
        return 1000 + 3;
    }
}