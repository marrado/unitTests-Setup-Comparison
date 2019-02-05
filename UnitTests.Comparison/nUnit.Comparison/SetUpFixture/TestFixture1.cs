using NUnit.Framework;

namespace nUnit.Comparison.SetUpFixture
{
    public class TestFixture1
    {
        [Test]
        public void Test1()
        {
            //Arrange/Act/Assert
        }

        [Test]
        public void Test2()
        {
            //Arrange/Act/Assert
        }

        [TestCase("param")]
        [TestCase("param2")]
        public void TestWithCases(string param)
        {
            //Arrange/Act/Assert
        }
    }
}