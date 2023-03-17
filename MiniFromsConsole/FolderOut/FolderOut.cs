using MiniFormsConsole.Core;

namespace MiniFormsConsole.FolderOut;

internal class FolderOut : IServiceModule
{
    private readonly LoggerService _logger;

    public FolderOut(LoggerService logger)
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
