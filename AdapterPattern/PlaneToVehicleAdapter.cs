namespace AdapterPattern
{
    internal class PlaneToVehicleAdapter : IVehicle
    {
        private readonly IPlane _plane;
        public PlaneToVehicleAdapter(IPlane plane)
        {
            _plane = plane;
        }
        public void Move()
        {
            _plane.Fly();
        }
    }
}
