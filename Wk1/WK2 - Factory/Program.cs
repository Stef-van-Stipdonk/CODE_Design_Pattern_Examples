// See https://aka.ms/new-console-template for more information

using WK2___Factory;
using WK2___Factory.Creators;

Console.WriteLine("Transported by:");
TransportPackage(new BoatCreator());

Console.WriteLine();

Console.WriteLine("Transported by:");
TransportPackage(new CarCreator());

Console.WriteLine();

Console.WriteLine("Transported by:");
TransportPackage(new PlaneCreator());

void TransportPackage(Creator creator)
{   
    Console.WriteLine(creator.ExecuteOperation());
}