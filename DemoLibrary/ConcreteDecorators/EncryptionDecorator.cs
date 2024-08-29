using DemoLibrary.BaseDecorators;
using DemoLibrary.ComponentInterfaces;

namespace DemoLibrary.ConcreteDecorators;

/// <summary>
/// Concrete Decorators call the wrapped object and alter its result in some way.
/// </summary>
public class EncryptionDecorator : DataSourceDecorator
{
    public EncryptionDecorator(DataSource source) : base(source) { }

    public override void WriteData(string data)
    {
        Console.WriteLine("Encrypting data");
        base.WriteData($"Encrypted({data})");
    }

    public override string ReadData()
    {
        string data = base.ReadData();
        Console.WriteLine("Decrypting data");
        Console.WriteLine($"Data is now : {data.Replace("Encrypted(", "").Replace(")", "")}");
        return data.Replace("Encrypted(", "").Replace(")", "");
    }
}
