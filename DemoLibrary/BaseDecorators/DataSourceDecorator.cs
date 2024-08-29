using DemoLibrary.ComponentInterfaces;

namespace DemoLibrary.BaseDecorators;

/// <summary>
/// The base Decorator class follows the same interface/(abstract class) as the other
/// components. The primary purpose of this class is to define the wrapping
/// interface for all concrete decorators. The default implementation of the
/// wrapping code might include a field for storing a wrapped component and
/// the means to initialize it.
/// </summary>
public abstract class DataSourceDecorator : DataSource
{
    protected DataSource Wrappee;

    protected DataSourceDecorator(DataSource source) => this.Wrappee = source;

    public override void WriteData(string data)
    {
        Wrappee.WriteData(data);
    }

    public override string ReadData()
    {
        return Wrappee.ReadData();
    }
}
