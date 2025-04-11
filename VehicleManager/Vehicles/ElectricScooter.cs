using VehicleManager.Errors;

namespace VehicleManager.Vehicles
{
    public class ElectricScooter : Vehicle
    {
        public int BatteryRange { get; set; }
        public int BatteryPercentage { get; set; }

        public SystemError? CheckBattery
        {
            get
            {
                if (BatteryPercentage < 20)
                {
                    return new BatteryChargeFailureError();
                }
                return null;
            }
        }

        public override string StartEngine()
        {
            return $"⚡ Silent power-on!";
        }

        public override string Stats()
        {
            return base.Stats() + $"| Battery Range: ⚡{BatteryRange}km | Battery Percentage: 🔋{BatteryPercentage}% ";
            ;
        }
    }
}