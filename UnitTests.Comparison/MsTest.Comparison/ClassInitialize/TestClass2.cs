using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Comparison;

namespace MsTest.Comparison.ClassInitialize
{
    [TestClass]
    public class TestClass2
    {
        [ClassInitialize]
        public static void TestInitialize(TestContext context)
        {
            //initialize once per class
            TestInitializer.Init(TestInitializer.MsTest + " - " + nameof(ClassInitialize));
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