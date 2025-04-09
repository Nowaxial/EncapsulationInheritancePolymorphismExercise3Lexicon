﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Errors
{
    public class EngineFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Engine failure : Check the engine!";
        }
    }
}
