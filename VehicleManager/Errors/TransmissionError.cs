using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Errors
{
    public class TransmissionError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Transmission Error : Check the transmission";
        }
    }
}
