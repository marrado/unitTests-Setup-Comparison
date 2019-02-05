using UnitTests.Comparison;
using Xunit;

namespace xUnit.Comparison.InitilizeOncePerTest
{
    /// <summary>
    /// In xUnit there's no OneTimeSetUp/ClassInitilize attribute and the setup needs to be done explicitly in class constructor.
    /// </summary>
    public class TestFixture1
    {
        public TestFixture1()
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