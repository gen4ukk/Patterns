namespace AbstractFactoryPattern
{
    internal class PorcsheRobot : IRobot
    {
        public ISkeleton Skeleton { get; set; }
        public IWeapon Weapon { get; set; }
    }
}
