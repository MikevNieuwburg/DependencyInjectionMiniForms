public class SampleClass
{
    private readonly IService1 _service1;
    private readonly IService2 _service2;
    private readonly IService3 _service3;

    public SampleClass(IService1 serviceA, IService2 serviceB, IService3 serviceC)
    {
        _service1 = serviceA;
        _service2 = serviceB;
        _service3 = serviceC;
    }

    public void DoSomething()
    {
        _service1.Method();
        _service1.MethodA();
        _service2.Method();
        _service2.MethodB();
        _service3.Method();
        _service3.MethodC();
    }
}
