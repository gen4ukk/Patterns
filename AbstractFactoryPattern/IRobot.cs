namespace AbstractFactoryPattern
{
    public interface IRobot
    {
        public ISkeleton Skeleton { get; set; }
        public IWeapon Weapon { get; set; }
    }
}