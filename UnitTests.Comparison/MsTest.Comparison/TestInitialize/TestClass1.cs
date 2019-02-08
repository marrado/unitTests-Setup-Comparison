using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Comparison;

namespace MsTest.Comparison.TestInitialize
{
    [TestClass]
    public class TestClass1
    {
        [TestInitialize]
        public void TestInitialize()
        {
            //initialize every test separately
            TestInitializer.Init(TestInitializer.MsTest + " - " + nameof(TestInitialize));
		}

        [TestCleanup]
        public void TestCleanup()
        {
	        TestInitializer.Cleanup(TestInitializer.MsTest + " - " + nameof(TestInitialize));
        }

		[TestMethod]
        public void Test1()
        {
            //Arrange/Act/Assert
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange/Act/Assert
        }

        [DataTestMethod]
        [DataRow("param")]
        [DataRow("param2")]
        public void TestWithCases(string param)
        {
            //Arrange/Act/Assert
        }
    }
}