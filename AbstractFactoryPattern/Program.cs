using AbstractFactoryPattern;

Console.WriteLine("Hello, World!");

AbstractRobotFactory robotFactory = new PorcsheFactory();

var robot = robotFactory.CreateRobot();

Console.ReadKey();