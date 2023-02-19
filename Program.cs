// See https://aka.ms/new-console-template for more information
using TuplesPractice;

Console.WriteLine("Hello, World!");
SimpleTuple simpleTuple = new SimpleTuple();
var result = simpleTuple.Process();
Console.WriteLine(result.Item1.FirstOrDefault());
foreach(var item in result.Item1)
{
    Console.WriteLine(item);
}
Console.WriteLine(result.Item1.FirstOrDefault());
Console.ReadLine();

