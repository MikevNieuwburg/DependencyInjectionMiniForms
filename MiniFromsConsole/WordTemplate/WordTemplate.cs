using MiniFormsConsole.Core;

namespace MiniFormsConsole.WordTemplate
{
    internal class WordTemplate : IServiceModule
    {
        private readonly LoggerService _logger;

        public WordTemplate(LoggerService logger)
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
}
