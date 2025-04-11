using VehicleManager.Interfaces;

namespace VehicleManager.Vehicles
{
    // En klass som representerar en bil och ärver från Vehicle och implementerar ICleanable
    public class Car : Vehicle, ICleanable
    {

        // Egenskaper för bil
        public int SeatsInVehicle { get; set; }


        // Konstruktorn som anropar basklassens konstruktor och lägger till specifika egenskaper
        public override string Stats()
        {
            return base.Stats() + $"| Seats: {SeatsInVehicle}";
        }

        // Konstruktorn som anropar basklassens konstruktor och lägger till specifika egenskaper
        public override string StartEngine()
        {
            return $"Car engine started with a key turn!";
        }

        //Implementation av ICleanable som definierar Clean() metoden
        public void Clean()
        {
            Console.WriteLine("Car washed and interior vacuumed.");
        }
    }
}