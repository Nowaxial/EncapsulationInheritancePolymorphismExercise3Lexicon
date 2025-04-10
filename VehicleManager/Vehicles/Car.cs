using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManager.Interfaces;


namespace VehicleManager.Vehicles
{
    public class Car : Vehicle
    {
        public int SeatsInVehicle { get; set; }

        public override string Stats()
        {
            return base.Stats() + $"| Seats: {SeatsInVehicle}";
        }

        public override string StartEngine()
        {
            return $"Car engine started with a key turn";
        }
    }
}
