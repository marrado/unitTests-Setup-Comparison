using System;
using UnitTests.Comparison;

namespace xUnit.Comparison.InitializeOnce
{
    public class SharedContext : IDisposable
    {
        public SharedContext()
        {
            TestInitializer.Init(TestInitializer.xUnit + " - " + nameof(InitializeOnce));
        }

        public void Dispose()
        {
			TestInitializer.Cleanup(TestInitializer.xUnit + " - " + nameof(InitializeOnce));
        }
    }
}