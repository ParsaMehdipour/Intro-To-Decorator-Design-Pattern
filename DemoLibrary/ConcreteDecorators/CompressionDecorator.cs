using DemoLibrary.BaseDecorators;
using DemoLibrary.ComponentInterfaces;

namespace DemoLibrary.ConcreteDecorators;

/// <summary>
/// Concrete Decorators call the wrapped object and alter its result in some way.
/// </summary>
public class CompressionDecorator : DataSourceDecorator
{
    public CompressionDecorator(DataSource source) : base(source) { }

    public override void WriteData(string data)
    {
        Console.WriteLine("Compressing data");
        base.WriteData($"Compressed({data})");
    }

    public override string ReadData()
    {
        string data = base.ReadData();
        Console.WriteLine("Decompressing data");
        Console.WriteLine($"Data is now : {data.Replace("Compressed(", "").Replace(")", "")}");
        return data.Replace("Compressed(", "").Replace(")", "");
    }
}
