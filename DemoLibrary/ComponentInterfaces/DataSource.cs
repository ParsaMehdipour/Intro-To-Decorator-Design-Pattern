namespace DemoLibrary.ComponentInterfaces;

/// <summary>
///The base Component interface/(abstract class) defines operations that can be altered by
/// decorators.
/// </summary>
public abstract class DataSource
{
    public abstract void WriteData(string data);
    public abstract string ReadData();
}
