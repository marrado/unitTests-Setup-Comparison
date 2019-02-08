using System;
using UnitTests.Comparison;
using Xunit;

namespace xUnit.Comparison.InitializeOncePerTest
{
    /// <summary>
    /// In xUnit there's no OneTimeSetUp/ClassInitialize attribute and the setup needs to be done explicitly in class constructor.
    /// </summary>
    public class TestFixture1 : IDisposable
    {
        public TestFixture1()
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
			TestInitializer.Cleanup(TestInitializer.xUnit + " - " + nameof(InitializeOncePerTest));
		}
    }
}