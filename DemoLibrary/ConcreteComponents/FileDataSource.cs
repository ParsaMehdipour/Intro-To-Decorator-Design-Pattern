using DemoLibrary.ComponentInterfaces;

namespace DemoLibrary.ConcreteComponents;

/// <summary>
/// Concrete Components provide default implementations of the operations.
/// There might be several variations of these classes.
/// </summary>
public class FileDataSource : DataSource
{
    private readonly string _filename;
    private string _data;

    public FileDataSource(string filename) => this._filename = filename;

    public override void WriteData(string data)
    {
        _data = data;
        Console.WriteLine($"Writing {_data} to file: {_filename}");
        // Actual file writing logic would go here
    }

    public override string ReadData()
    {
        Console.WriteLine($"Reading {_data} from file: {_filename}");
        // Actual file reading logic would go here
        return $"{_data} from file";
    }
}
