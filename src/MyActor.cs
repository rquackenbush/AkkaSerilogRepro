using Akka.Actor;
using Akka.Event;

namespace AkkaSerilogRepo;

public class MyActor : ReceiveActor
{
    private readonly ILoggingAdapter _log = Context.GetLogger();
    
    protected override void PreStart()
    {
        var testObj = new { testInt = 1, testVal = "test1" };
        IActorRef testActorRef = Self;
        
        _log.Info("1. Starting client handler logging test");
        _log.Info("2. Starting client handler testObj: {TestObj}", testObj);
        _log.Info("3. Starting client handler testObj: {@TestObj}", testObj);
        _log.Info("4. Starting client handler {@TestActorRef}", testActorRef);
        _log.Info("5. Starting client handler {TestActorRef}", testActorRef);
        _log.Info("6. End client handler logging test");                
    }
}