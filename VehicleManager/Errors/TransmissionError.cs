namespace VehicleManager.Errors
{
    public class TransmissionError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Transmission Error : Check the transmission!";
        }
    }
}