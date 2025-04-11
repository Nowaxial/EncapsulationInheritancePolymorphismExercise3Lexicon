namespace VehicleManager.Vehicles;

public class Motorcycle : Vehicle
{
    // Egenskaper för motorcykel
    public bool HasSideSeat { get; set; }

    // Konstruktorn overridar basens konstruktor och lägger till specifika egenskaper
    public override string StartEngine()
    {
        return "Motor cycle engine revved loudly.";
    }

    //Konstruktorn overridar basens konstruktor och lägger till specifika egenskaper
    public override string Stats()
    {
        return $"{base.Stats()}| Has Sideseat: {HasSideSeat}"
        ;
    }
}