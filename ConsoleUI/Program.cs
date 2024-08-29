using DemoLibrary.ComponentInterfaces;
using DemoLibrary.ConcreteComponents;
using DemoLibrary.ConcreteDecorators;

// The client code works with all objects using the Component interface.
// This way it can stay independent of the concrete classes of
// components it works with.

Console.WriteLine("Simple decorator example:");
DataSource source = new FileDataSource("somefile.dat");
source.WriteData("Hello, World!");

source = new CompressionDecorator(source);
source.WriteData("Hello, World!");

source = new EncryptionDecorator(source);
source.WriteData("Hello, World!");

Console.WriteLine("\nReading data:");
Console.WriteLine(source.ReadData());

// Configurable example
Console.WriteLine("\nConfigurable decorator example:");
bool enabledEncryption = true;
bool enabledCompression = true;

DataSource configuredSource = new FileDataSource("salary.dat");
if (enabledEncryption)
{
    configuredSource = new EncryptionDecorator(configuredSource);
}
if (enabledCompression)
{
    configuredSource = new CompressionDecorator(configuredSource);
}

configuredSource.WriteData("Salary data");
Console.WriteLine("Reading configured data:");
Console.WriteLine(configuredSource.ReadData());