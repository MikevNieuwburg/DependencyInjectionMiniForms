using MiniFormsConsole.Core;

namespace MiniFormsConsole.Encode;

internal class Encode : IServiceModule
{
    private readonly LoggerService _logger;

    public Encode(LoggerService logger)
    {
        _logger = logger;
    }
    public bool Completed => throw new NotImplementedException();

    public int Order { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Run()
    {
        throw new NotImplementedException();
    }
}
