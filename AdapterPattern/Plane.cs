namespace AdapterPattern
{
    internal class Plane : IPlane
    {
        public void Fly()
        {
            Console.WriteLine("==> plane ==>");
        }
    }

    internal interface IPlane 
    {
        void Fly();
    }
}
