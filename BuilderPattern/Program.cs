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

var robot = robotBuilder.AddHead()
    .AddHands()
    .AddBody()
    .AddHands()
    .AddLegs()
    .AddBoots()
    .CreateProduct();

robot.Show();