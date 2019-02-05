using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Comparison;

namespace MsTest.Comparison.AssemblyInitialize
{
    [TestClass]
    public class AssemblyInitialize
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            //initialize once per assembly
            TestInitializer.Init(TestInitializer.MsTest + " - " + nameof(AssemblyInitialize));
        }
    }
}