namespace AbstractFactoryPattern
{
    internal abstract class AbstractRobotFactory
    {
        protected IWeapon _weapon;
        protected ISkeleton _skeleton;

        public IWeapon GetWeapon() 
        {
            return _weapon;
        }
        public ISkeleton GetSkeleton()
        {
            return _skeleton;
        }
        public abstract IRobot CreateRobot();
    }
}
