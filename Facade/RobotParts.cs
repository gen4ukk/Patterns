namespace Facade
{

    internal class RobotHead
    {
        public string Model { get; set; }

    }

    internal class RobotBody
    {
        public string Model { get; set; }
    }

    internal class RobotLegs
    {
        public string Model { get; set; }
    }

    internal class Robot
    {
        public RobotHead RobotHead { get; set; }
        public RobotBody RobotBody { get; set; }
        public RobotLegs RobotLegs { get; set; }
    }
}
