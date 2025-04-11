﻿namespace VehicleManager.Errors
{
    public class EngineFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Engine failure : Check the engine!";
        }
    }
}