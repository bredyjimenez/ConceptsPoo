// See https://aka.ms/new-console-template for more information
using ConceptoPoo;

Console.WriteLine("Concept Poo");
Console.WriteLine("===========");
try
{
	Console.WriteLine(new Date(2025, 2, 22));
	Console.WriteLine(new Date(2021, 7, 25));
	Console.WriteLine(new Date(1989, 11, 30));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}