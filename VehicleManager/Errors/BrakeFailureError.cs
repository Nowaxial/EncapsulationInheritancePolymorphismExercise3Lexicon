namespace VehicleManager.Errors
{
    public class BrakeFailureError : SystemError
    {

        // Konstruktorn overridar basens konstruktor och lägger till specifika egenskaper

        public override string ErrorMessage()
        {
            return "Break failure: You need to get new breaks!";
        }
    }
}