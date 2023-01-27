using Wolverine;

namespace WolverineDualMiddleware;

public record SampleEntity1(Guid Id, int Value1);

public record SampleEntity2(Guid Id, string Value2);

public interface IEntity1Command { public Guid Entity1Id { get; init; } }

public interface IEntity2Command { public Guid Entity2Id { get; init; } }

public record SampleCommand(Guid Entity1Id, Guid Entity2Id) : IEntity1Command, IEntity2Command;

public class SampleMiddleware
{
    public static (HandlerContinuation, SampleEntity1?) Before(IEntity1Command command)
    {
        return (HandlerContinuation.Continue, new SampleEntity1(Guid.NewGuid(), 1));
    }
    public static (HandlerContinuation, SampleEntity2?) Before(IEntity2Command command)
    {
        return (HandlerContinuation.Continue, new SampleEntity2(Guid.NewGuid(), "2"));
    }
}

public static class SampleHandler
{
    public static void Handle(SampleCommand command, SampleEntity1 entity1, SampleEntity2 entity2)
    {
        
    }
}