public interface IService2 : IService
{
    void IService.Method() { Console.WriteLine("Log sample data."); }
    void MethodB();
}
