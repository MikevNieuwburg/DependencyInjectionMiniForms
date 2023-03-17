using MiniFormsConsole.Core;

namespace MiniFormsConsole.Decode;

internal class Decode : IServiceModule
{
    private readonly LoggerService _logger;

    public Decode(LoggerService logger)
    {
        _logger = logger;
    }
    public bool Completed { get; private set; }

    public int Order { get; set; }

    public void Run()
    {
        throw new NotImplementedException();
    }
}
