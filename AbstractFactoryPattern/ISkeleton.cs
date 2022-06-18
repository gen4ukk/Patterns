namespace AbstractFactoryPattern
{
    public interface ISkeleton
    {
        public string Model { get; set; }
        public string Version { get; set; }
        public int Weight { get; set; }
    }
}