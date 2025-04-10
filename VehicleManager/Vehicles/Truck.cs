using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Vehicles
{
    public class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }

        public override string StartEngine()
        {
            return $"🛻Truck rumbled to life!";
        }

        public override string Stats()
        {
            return $"{base.Stats()}| Cargo Capacity: {CargoCapacity}kg";
        }
    }
}
