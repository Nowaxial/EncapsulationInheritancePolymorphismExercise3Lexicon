using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Errors
{
    public class FuelFailureError : SystemError
    {
        // Konstruktorn overridar basens konstruktor och lägger till specifika egenskaper
        public override string ErrorMessage()
        {
            return "Fuel Error: Refuel!";
        }
    }
}
