using FactoryPattern.Interfaces;

namespace FactoryPattern;

public class NOGI : IFactory
{
    public decimal CalculatePrice()
    {
        return 1000 + 2;
    }
}