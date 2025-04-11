namespace VehicleManager.Errors
{
    public class TransmissionError : SystemError
    {
        // Konstruktorn overridar basens konstruktor och lägger till specifika egenskaper
        public override string ErrorMessage()
        {
            return "Transmission Error : Check the transmission!";
        }
    }
}