namespace GOF.Creationals._Builder.RealWorld
{
    public abstract class VehicleBuilder(VehicleType vehicleType)
    {
        public Vehicle Vehicle { get; private set; } = new Vehicle(vehicleType);
        
        public abstract void BuildFrame();       
        public abstract void BuildEngine();       
        public abstract void BuildWheels();       
        public abstract void BuildDoors();       
    }
}
