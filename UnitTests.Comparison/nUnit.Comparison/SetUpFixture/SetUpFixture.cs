using NUnit.Framework;
using UnitTests.Comparison;

namespace nUnit.Comparison.SetUpFixture
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            //initialize once per all tests in the namespace
            TestInitializer.Init(TestInitializer.nUnit + " - " + nameof(SetUpFixture));
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			TestInitializer.Cleanup(TestInitializer.nUnit + " - " + nameof(SetUpFixture));
		}
	}
}