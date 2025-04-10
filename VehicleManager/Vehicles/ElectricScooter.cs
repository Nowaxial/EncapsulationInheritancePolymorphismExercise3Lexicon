using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Vehicles
{
    public class ElectricScooter :Vehicle
    {
        
        public int BatteryRange { get; set; }
        public int BatteryPercentage { get; set; }

        public override string StartEngine()
        {
            return $"🛵⚡ Silent power-on!";
        }

        public override string Stats()
        {
            return base.Stats() +  $"| Battery Range: ⚡{BatteryRange}km | Battery Percentage: 🔋{BatteryPercentage}% ";
            ;
        }
    }
}
