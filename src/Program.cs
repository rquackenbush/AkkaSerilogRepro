// See https://aka.ms/new-console-template for more information

using Akka.Actor;
using AkkaSerilogRepo;
using Serilog;

var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .MinimumLevel.Information()
    .CreateLogger();

Serilog.Log.Logger = logger;

var myActorSystem = ActorSystem.Create("myActorSystem", "akka { loglevel=INFO,  loggers=[\"Akka.Logger.Serilog.SerilogLogger, Akka.Logger.Serilog\"]}");

var myActor = myActorSystem.ActorOf(Props.Create<MyActor>());

myActorSystem.WhenTerminated.Wait();