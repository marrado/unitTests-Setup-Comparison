using UnitTests.Comparison;
using Xunit;

namespace xUnit.Comparison.InitilizeOncePerTest
{
    public class TestFixture2
    {
        public TestFixture2()
        {
            TestInitializer.Init(TestInitializer.xUnit + " - " + nameof(InitilizeOncePerTest));
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
    }
}