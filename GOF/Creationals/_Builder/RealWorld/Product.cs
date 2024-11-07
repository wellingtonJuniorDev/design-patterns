namespace GOF.Creationals._Builder.RealWorld
{
    public class Vehicle(VehicleType vehicleType)
    {
        private readonly Dictionary<PartType, string> parts = [];
        private readonly VehicleType vehicleType = vehicleType;

        public string this[PartType key]
        {
            get => parts[key];
            set => parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vehicle Type: {vehicleType}");

            Console.WriteLine($" #Frame  : {this[PartType.Frame]}");
            Console.WriteLine($" #Engine : {this[PartType.Engine]}");
            Console.WriteLine($" #Wheels : {this[PartType.Wheel]}");
            Console.WriteLine($" #Doors  : {this[PartType.Door]}");
        }
    }

    public enum PartType
    {
        Frame,
        Engine,
        Wheel,
        Door
    }

    public enum VehicleType
    {
        Car,
        Scooter,
        MotorCycle
    }
}
