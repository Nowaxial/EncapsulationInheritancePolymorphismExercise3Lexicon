namespace VehicleManager.Errors
{
    public class BatteryChargeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Battery Failure: Charge or replace the battery!";
        }
    }
}