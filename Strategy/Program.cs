// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");

TextSaverManager manager = new TextSaverManager();

manager.SetStrategy(new ConsoleStrategy());

manager.Display("strategy 1");

manager.SetStrategy(new FileStrategy());

manager.Display("strategy 2");
