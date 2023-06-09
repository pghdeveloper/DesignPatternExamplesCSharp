using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class BOP : IFactory
{
    public decimal CalculatePremium()
    {
        return 1000 + 1;
    }
}