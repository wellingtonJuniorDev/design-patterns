namespace GOF.Creationals._Builder.RealWorld
{
    public class MotorcyleBuilder : VehicleBuilder
    {
        public MotorcyleBuilder() : base(VehicleType.MotorCycle) { }

        public override void BuildDoors() => Vehicle[PartType.Frame] = "Motorcycle Frame";
        public override void BuildEngine() => Vehicle[PartType.Engine] = "500cc";
        public override void BuildFrame() => Vehicle[PartType.Wheel] = "2";
        public override void BuildWheels() => Vehicle[PartType.Door] = "0";
    }

    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder() : base(VehicleType.Car) { }

        public override void BuildFrame() => Vehicle[PartType.Frame] = "Car Frame";
        public override void BuildEngine() => Vehicle[PartType.Engine] = "2500 cc";
        public override void BuildWheels() => Vehicle[PartType.Wheel] = "4";
        public override void BuildDoors() => Vehicle[PartType.Door] = "4";
    }

    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder() : base(VehicleType.Scooter) { }

        public override void BuildFrame() => Vehicle[PartType.Frame] = "Scooter Frame";
        public override void BuildEngine() => Vehicle[PartType.Engine] = "50 cc";
        public override void BuildWheels() => Vehicle[PartType.Wheel] = "2";
        public override void BuildDoors() => Vehicle[PartType.Door] = "0";
    }
}
