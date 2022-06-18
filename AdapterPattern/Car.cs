namespace AdapterPattern
{
    internal class Car : IVehicle
    {
        public void Move()
        {
            Console.WriteLine("==> car ==>");
        }
    }

    internal interface IVehicle
    {
        void Move();
    }
}
