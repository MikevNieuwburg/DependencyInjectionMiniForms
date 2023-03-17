using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFormsConsole.Core
{
    internal class ServiceRunner
    {
        private readonly LoggerService _logger;

        private List<IServiceModule> modules = new List<IServiceModule>();

        public ServiceRunner(LoggerService logger)
        {
            _logger = logger;
        }

        public int ServicesCount() => modules.Count;

        public void RunServices()
        {
            foreach (var module in modules)
            {
                module.Run();
            }
        }

        public void Add(IServiceModule module)
        {
            _logger.Log($"{module} has been added.");
            modules.Add(module);
        }
        public void Remove(IServiceModule module)
        {
            _logger.Log($"{module} has been removed.");
            modules.Remove(module);
        }
    }
}
