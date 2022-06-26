namespace Facade
{
    internal class RobotFacade
    {
        public Robot CreateRobot(string model) 
        {
            HeadRobotCreator headRobot = new HeadRobotCreator();
            var head = headRobot.Create(model);

            BodyRobotCreator bodyRobotCreator = new BodyRobotCreator();
            var body = bodyRobotCreator.Create(model);

            LegsRobotCreator legsRobotCreator = new LegsRobotCreator();
            var legs = legsRobotCreator.Create(model);

            RobotCreator robotCreator = new RobotCreator();
            var robot = robotCreator.Create(head, body, legs);

            return robot;
        }
    }
}
