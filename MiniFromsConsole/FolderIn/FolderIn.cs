using MiniFormsConsole.Core;

namespace MiniFormsConsole.FolderIn;

internal class FolderIn : IServiceModule
{
    private readonly LoggerService _logger;

    public FolderIn(LoggerService logger)
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
