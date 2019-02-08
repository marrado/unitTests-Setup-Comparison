using NUnit.Framework;
using UnitTests.Comparison;

namespace nUnit.Comparison.OneTimeSetUp
{
    public class TestFixture1
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            //initialize once per class
            TestInitializer.Init(TestInitializer.nUnit + " - " + nameof(OneTimeSetUp));
		}

        [OneTimeTearDown]
        public void TearDown()
        {
	        TestInitializer.Cleanup(TestInitializer.nUnit + " - " + nameof(OneTimeSetUp));
        }

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