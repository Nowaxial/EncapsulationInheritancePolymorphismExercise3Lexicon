using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Errors
{
    public class BatteryChargeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Battery Failure: Charge the battery!";
        }
    }
}
