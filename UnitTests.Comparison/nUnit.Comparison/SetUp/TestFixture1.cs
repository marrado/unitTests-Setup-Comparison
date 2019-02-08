using NUnit.Framework;
using UnitTests.Comparison;

namespace nUnit.Comparison.SetUp
{
    public class TestFixture1
    {
        [SetUp]
        public void SetUp()
        {
            //initialize every test separately
            TestInitializer.Init(TestInitializer.nUnit + " - " + nameof(SetUp));
		}

        [TearDown]
        public void TearDown()
        {
	        TestInitializer.Cleanup(TestInitializer.nUnit + " - " + nameof(SetUp));
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