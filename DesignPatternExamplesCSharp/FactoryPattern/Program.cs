// See https://aka.ms/new-console-template for more information

using FactoryPattern;
using FactoryPattern.Interfaces;

ApplicationTypeFactory factory = new ConcreteApplicationTypeFactory();

IFactory bop = factory.GetApplicationType("BOP");
Console.WriteLine("BOP: " + bop.CalculatePremium());

IFactory gl = factory.GetApplicationType("GL");
Console.WriteLine("GL: " + gl.CalculatePremium());

Console.ReadKey();