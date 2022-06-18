namespace AbstractFactoryPattern
{
    internal class PorcsheFactory : AbstractRobotFactory
    {
        public PorcsheFactory()
        {
            _weapon = new PorcsheWeapon() { Model = "porsheW", Version = "V1" };
            _skeleton = new PorcsheSkeleton() { Model = "porsheS", Version = "V1.1", Weight = 2000 };
        }

        public override IRobot CreateRobot()
        {
            Console.WriteLine("Yahooo I created porcshe robot ");

            return new PorcsheRobot() { Skeleton = _skeleton, Weapon = _weapon };
        }
    }
}
