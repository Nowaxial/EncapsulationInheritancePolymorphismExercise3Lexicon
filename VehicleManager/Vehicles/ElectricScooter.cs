using VehicleManager.Errors;

namespace VehicleManager.Vehicles
{

    // Konstruktorn overridar basens konstruktor och lägger till specifika egenskaper

    public class ElectricScooter : Vehicle
    {
        public int BatteryRange { get; set; }
        public int BatteryPercentage { get; set; }


        //Skapa en ny instans av BatteryChargeFailureError som ärver från SystemError
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

        //Konstruktorn som overrider basklassens konstruktor och lägger till specifika egenskaper
        public override string StartEngine()
        {
            return $"⚡ Silent power-on!";
        }

        //Konstruktorn som overrider basklassens konstruktor och lägger till specifika egenskaper
        public override string Stats()
        {
            return base.Stats() + $"| Battery Range: ⚡{BatteryRange}km | Battery Percentage: 🔋{BatteryPercentage}% ";
            ;
        }
    }
}