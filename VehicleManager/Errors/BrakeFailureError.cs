using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Errors
{


    public class BrakeFailureError : SystemError
        {
        public override string ErrorMessage()
        {
            return "Break failure: You need to get new breaks!";
        }
    }
    
}
