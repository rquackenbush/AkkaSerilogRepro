# AkkaSerilogRepro

Reproduces [this error](https://github.com/akkadotnet/Akka.Logger.Serilog/issues/183). 

## Instructions
- Open solution (in [/src](src))
- Run it

Sample output:

```
[15:25:12 INF] 1. Starting client handler logging test
[15:25:12 INF] 2. Starting client handler testObj: { testInt = 1, testVal = test1 }
[15:25:12 INF] 3. Starting client handler testObj: {"testInt": 1, "testVal": "test1"}
```

This should have 3 more lines, but the actor dies when attempting to log an `IActorRef`.
