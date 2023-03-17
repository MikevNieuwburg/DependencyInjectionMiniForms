namespace MiniFormsConsole.Core
{
    internal interface IServiceModule
    {
        void Run();
        bool Completed { get; }
        int Order { get; set; }
    }
}
