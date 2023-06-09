using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class GI : IFactory
{
    public decimal CalculatePrice()
    {
        return 1000 + 1;
    }
}