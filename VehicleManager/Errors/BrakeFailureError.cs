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