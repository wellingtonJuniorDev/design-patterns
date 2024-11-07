namespace GOF.Creationals._Builder.RealWorld
{
    public class Shop
    {
        private VehicleBuilder builder;

        public void Construct(VehicleBuilder vehicleBuilder)
        {
            builder = vehicleBuilder;

            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
        }

        public void ShowVehicle() => builder.Vehicle.Show();
    }
}
