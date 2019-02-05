using Xunit;

namespace xUnit.Comparison.InitializeOncePerClass
{
    public class TestFixture1 : IClassFixture<TestBase>
    {
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