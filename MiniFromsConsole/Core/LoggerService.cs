namespace MiniFormsConsole.Core
{
    internal class LoggerService 
    {
        private readonly IConsoleLogger _logger;

        public LoggerService(IConsoleLogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
