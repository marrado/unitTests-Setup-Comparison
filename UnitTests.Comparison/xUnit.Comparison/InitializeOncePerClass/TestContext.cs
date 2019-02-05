using System;
using UnitTests.Comparison;

namespace xUnit.Comparison.InitializeOncePerClass
{
    public class TestBase : IDisposable
    {
        public TestBase()
        {
            TestInitializer.Init(TestInitializer.xUnit + " - " + nameof(InitializeOncePerClass));
        }

        public void Dispose()
        {
        }
    }
}