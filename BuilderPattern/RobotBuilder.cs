using System.Text.Json;

namespace BuilderPattern
{
    internal class RobotBuilder : IBuilder
    {
        private Robot _robot = new Robot();
        private RobotConfig _robotConfig = null;
        List<string> _robotPartsList = null;

        public RobotBuilder()
        {
            string jsonString = File.ReadAllText("config.json");
            _robotConfig = JsonSerializer.Deserialize<RobotConfig>(jsonString);

            string robotFile = File.ReadAllText("robot.txt");
            _robotPartsList = robotFile.Split(Environment.NewLine).ToList();

        }

        public IBuilder AddBody()
        {
            var parts = GetPartLines(_robotConfig.BodyStartLine, _robotConfig.BodyEndLine);

            _robot.AddPart(string.Join(Environment.NewLine, parts));
            
            return this;
        }

        public IBuilder AddBoots()
        {
            var parts = GetPartLines(_robotConfig.BootsStartLine, _robotConfig.BootsEndLine);

            _robot.AddPart(string.Join(Environment.NewLine, parts));

            return this;
        }

        public IBuilder AddHands()
        {
            var parts = GetPartLines(_robotConfig.HandsStartLine, _robotConfig.HandsEndLine);

            _robot.AddPart(string.Join(Environment.NewLine, parts));

            return this;
        }

        public IBuilder AddHead()
        {
            var parts = GetPartLines(_robotConfig.HeadStartLine, _robotConfig.HeadEndLine);

            _robot.AddPart(string.Join(Environment.NewLine, parts));

            return this;
        }

        public IBuilder AddLegs()
        {
            var parts = GetPartLines(_robotConfig.LegsStartLine, _robotConfig.LegsEndLine);

            _robot.AddPart(string.Join(Environment.NewLine, parts));

            return this;
        }

        public IBuilder AddNeck()
        {
            var parts = GetPartLines(_robotConfig.NeckStartLine, _robotConfig.NeckEndLine);

            _robot.AddPart(string.Join(Environment.NewLine, parts));

            return this;
        }

        public IProduct CreateProduct()
        {
            return _robot;
        }

        private IEnumerable<string> GetPartLines(int startLine, int endLine)
        {
            return _robotPartsList.Skip(startLine-1)
                .Take(endLine - startLine + 1);
        }
    }
}
