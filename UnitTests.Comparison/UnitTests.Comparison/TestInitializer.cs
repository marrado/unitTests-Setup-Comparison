using System.Diagnostics;
using System.Threading;

namespace UnitTests.Comparison
{
    public class TestInitializer
    {
        public const string MsTest = "MsTest";
        public const string nUnit = "nUnit";
        public const string xUnit = "xUnit";
        public const string SpecFlow = "SpecFlow";

        /// <summary>
        /// Method to simulate long test setup time.
        /// </summary>
        public static void Init(string callerName)
        {
            Debug.WriteLine($"{nameof(Init)} at {callerName}");
            Thread.Sleep(1000);
        }

        public static void Cleanup(string callerName)
		{
			Debug.WriteLine($"{nameof(Cleanup)} at {callerName}");
		}
    }
}