// See https://aka.ms/new-console-template for more information

using FactoryPattern;
using FactoryPattern.Interfaces;

UniformTypeFactory factory = new ConcreteUniformTypeFactory();

IFactory gi = factory.GetUniformType("GI");
Console.WriteLine("GI: " + gi.CalculatePrice());

IFactory noGi = factory.GetUniformType("NOGI");
Console.WriteLine("NOGI: " + noGi.CalculatePrice());

Console.ReadKey();