using TechTalk.SpecFlow;
using UnitTests.Comparison;

namespace SpecFlow.Comparison.Infrastructure
{
    /// <summary>
    /// The following three methods will be translated to the analogical structure
    /// in the chosen testing framework (you can configure it, choosing between xUnit, nUnit and MsTest).
    /// The code behind for files will be automatically generated,
    /// but you have to do define test setup using following attributes.
    /// </summary>
    [Binding]
    public class TestSetup
    {
		//the comparisons below are generalized, as those steps are translated to any chosen framework
		//in this example they are translated to xUnit
        //like AssemblyInitialize
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            TestInitializer.Init(TestInitializer.SpecFlow + " - " + nameof(BeforeTestRun));
        }

        //like ClassInitialize
        [BeforeFeature]
        public static void BeforeFeature()
        {
            TestInitializer.Init(TestInitializer.SpecFlow + " - " + nameof(BeforeFeature));
        }

        //like TestInitialize
        [BeforeScenario]
        public void BeforeScenario()
        {
            TestInitializer.Init(TestInitializer.SpecFlow + " - " + nameof(BeforeScenario));
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
	        TestInitializer.Cleanup(TestInitializer.SpecFlow + " - " + nameof(BeforeTestRun));
        }

        [AfterFeature]
        public static void AfterFeature()
        {
	        TestInitializer.Cleanup(TestInitializer.SpecFlow + " - " + nameof(BeforeFeature));
        }
		
        [AfterScenario]
        public void AfterScenario()
        {
	        TestInitializer.Cleanup(TestInitializer.SpecFlow + " - " + nameof(BeforeScenario));
        }
	}
}