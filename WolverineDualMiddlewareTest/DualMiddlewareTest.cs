using Alba;
using Wolverine.Tracking;
using WolverineDualMiddleware;


namespace WolverineDualMiddlewareTest;

public class DualMiddlewareTest
{
    [Fact]
    public async Task TwoBeforeMethodsDefinedWork()
    {
        var host = await AlbaHost.For<Program>();
        await host.InvokeMessageAndWaitAsync(new SampleCommand(Guid.NewGuid(), Guid.NewGuid()));
    }
}