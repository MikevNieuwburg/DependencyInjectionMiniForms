using Microsoft.Extensions.DependencyInjection;


public interface IService1 : IService
{
    void IService.Method() { Console.WriteLine("Log sample data."); }
    void MethodA();
}
