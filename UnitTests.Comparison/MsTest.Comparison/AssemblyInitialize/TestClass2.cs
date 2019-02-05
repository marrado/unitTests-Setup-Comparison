using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest.Comparison.AssemblyInitialize
{
    [TestClass]
    public class TestClass2
    {
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