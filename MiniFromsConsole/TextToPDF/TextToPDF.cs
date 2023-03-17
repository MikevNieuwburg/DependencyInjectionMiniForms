using MiniFormsConsole.Core;

namespace MiniFormsConsole.TextToPDF;

internal class TextToPDF : IServiceModule
{
    private readonly LoggerService _logger;

    public TextToPDF(LoggerService logger)
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
