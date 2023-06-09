// See https://aka.ms/new-console-template for more information

using BuilderPattern;

var uniformCreator = new UniformCreator(new UniformBuilder());  
uniformCreator.CreateUniform();  
var uniform = uniformCreator.GetUniform(); 

Console.WriteLine("Uniform Id: " + uniform.Id); 