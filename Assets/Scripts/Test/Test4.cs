namespace Test
{
    public struct ApiSetup<T>
    {
    }

    internal class Api
    {
        public ApiSetup<T> For<T>(T obj)
        {
            return new ApiSetup<T>();
        }
    }

    internal interface ISomeInterfaceA
    {
    }

    internal interface ISomeInterfaceB
    {
    }

    public class ObjectA : ISomeInterfaceA
    {
    }

    public class ObjectB : ISomeInterfaceB
    {
    }

    internal class SomeClass
    {
        public void Setup()
        {
            var apiObject = new Api();

            apiObject.For(new ObjectA()).SetupObjectA();
            apiObject.For(new ObjectB()).SetupObjectB();
            // apiObject.For(new ObjectA()).SetupObjectB(); // error
            // apiObject.For(new ObjectB()).SetupObjectA(); // error
        }
    }

    internal static class ApiExtensions
    {
        internal static void SetupObjectA(this ApiSetup<ObjectA> api)
        {
        }
        
        internal static void SetupObjectB(this ApiSetup<ObjectB> api)
        {
        }
    }
}