namespace Test
{
    internal interface ISomeInterface
    {
        void Call();
    }

    internal class SomeClass : ISomeInterface
    {
        public void Call()
        {
        }
    }

    internal class Test3
    {
        public void Run()
        {
            var someStruct = new SomeClass();
            SomeMethod(someStruct);
        }

        public void SomeMethod(ISomeInterface @interface)
        {
            @interface.Call();
        }
    }
}