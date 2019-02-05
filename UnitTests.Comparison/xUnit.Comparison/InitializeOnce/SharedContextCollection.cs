using Xunit;

namespace xUnit.Comparison.InitializeOnce
{
    [CollectionDefinition("TestBase collection")]
    public class SharedContextCollection : ICollectionFixture<SharedContext>
    {
        
    }
}