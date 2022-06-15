using BuilderPattern;

RobotBuilder robotBuilder = new RobotBuilder();

//var robot = robotBuilder
//    .AddHead()
//    .AddNeck()
//    .AddHands()
//    .AddBody()
//    .AddLegs()
//    .AddBoots()
//    .CreateProduct();

var robot = robotBuilder
    .AddHead()
    .AddNeck()
    .AddHands()
    .AddBody()
    .AddHead()
    .AddLegs()
    .AddBoots()
    .CreateProduct();

robot.Show();