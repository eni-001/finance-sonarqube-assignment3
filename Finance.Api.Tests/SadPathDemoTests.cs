using Xunit;

namespace Finance.Api.Tests;

public class SadPathDemoTests
{
    [Fact]
    public void Pipeline_Blocks_Deliberate_Test_Failure()
    {
        Assert.True(
            false,
            "Deliberate failure used to demonstrate the CI sad path.");
    }
}