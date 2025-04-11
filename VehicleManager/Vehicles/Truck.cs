using VehicleManager.Interfaces;

namespace VehicleManager.Vehicles
{

    // En klass som representerar en lastbil och ärver från Vehicle och implementerar ICleanable
    public class Truck : Vehicle, ICleanable
    {
        public double CargoCapacity { get; set; }

        //Implementation av ICleanable som definierar Clean() metoden
        public void Clean()
        {
            Console.WriteLine("Truck exterior washed and cargo area cleaned.");
        }

        //Konstruktorn som overridear basklassens konstruktor och lägger till specifika egenskaper
        public override string StartEngine()
        {
            return $"Truck rumbled to life!";
        }


        //konstruktorn som overridear basklassens konstruktor och lägger till specifika egenskaper
        public override string Stats()
        {
            return $"{base.Stats()}| Cargo Capacity: {CargoCapacity}kg";
        }
    }
}