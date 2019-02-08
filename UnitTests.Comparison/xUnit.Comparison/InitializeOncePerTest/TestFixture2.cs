using System;
using UnitTests.Comparison;
using Xunit;

namespace xUnit.Comparison.InitializeOncePerTest
{
    public class TestFixture2 : IDisposable
    {
        public TestFixture2()
        {
            TestInitializer.Init(TestInitializer.xUnit + " - " + nameof(InitializeOncePerTest));
        }

        [Fact]
        public void Test1()
        {
            //Arrange/Act/Assert
        }
        
        [Fact]
        public void Test2()
        {
            //Arrange/Act/Assert
        }

        [Theory]
        [InlineData("param")]
        [InlineData("param2")]
        public void TestWithCases(string param)
        {
            //Arrange/Act/Assert
        }

        public void Dispose()
		{
			TestInitializer.Cleanup(TestInitializer.xUnit + " - " + nameof(InitializeOnce));
		}
    }
}