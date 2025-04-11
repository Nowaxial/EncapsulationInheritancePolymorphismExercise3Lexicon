using VehicleManager.Interfaces;

namespace VehicleManager.Vehicles
{
    public class Truck : Vehicle, ICleanable
    {
        public double CargoCapacity { get; set; }

        public void Clean()
        {
            Console.WriteLine("Truck exterior washed and cargo area cleaned.");
        }

        public override string StartEngine()
        {
            return $"Truck rumbled to life!";
        }

        public override string Stats()
        {
            return $"{base.Stats()}| Cargo Capacity: {CargoCapacity}kg";
        }
    }
}