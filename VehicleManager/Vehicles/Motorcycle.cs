namespace VehicleManager.Vehicles;

public class Motorcycle : Vehicle
{
    public bool HasSideSeat { get; set; }

    public override string StartEngine()
    {
        return "Motor cycle engine revved loudly";
    }

    public override string Stats()
    {
        return $"{base.Stats()}| Has Sideseat: {HasSideSeat}"
        ;
    }
}