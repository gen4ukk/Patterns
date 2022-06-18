namespace AbstractFactoryPattern
{
    internal class PorcsheSkeleton : ISkeleton
    {
        public string Model { get; set; }
        public string Version { get; set; }
        public int Weight { get; set; }
    }
}
