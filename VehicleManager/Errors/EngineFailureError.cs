namespace VehicleManager.Errors
{
    public class EngineFailureError : SystemError
    {

        // Konstruktorn overridar basens konstruktor och lägger till specifika egenskaper

        public override string ErrorMessage()
        {
            return "Engine failure : Check the engine!";
        }
    }
}