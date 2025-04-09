using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Errors
{


    public class BrakeFailure : SystemError
        {
        public override string ErrorMessage()
        {
            return "Break failure: Check breaks!";
        }
    }
    
}
