// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");

var model = "777";

HeadRobotCreator headRobot = new HeadRobotCreator();
var head = headRobot.Create(model);

BodyRobotCreator bodyRobotCreator = new BodyRobotCreator();
var body = bodyRobotCreator.Create(model);

LegsRobotCreator legsRobotCreator = new LegsRobotCreator();
var legs = legsRobotCreator.Create(model);

RobotCreator robotCreator = new RobotCreator();
var robot = robotCreator.Create(head, body, legs);

// =+=+=+=+=+=+=+=+= FACADE =+=+=+=+=+=+=+=+=

RobotFacade robotFacade = new RobotFacade();
var robot2 = robotFacade.CreateRobot(model);