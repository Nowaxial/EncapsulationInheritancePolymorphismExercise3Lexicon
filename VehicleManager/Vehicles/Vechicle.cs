namespace VehicleManager.Vehicles;

public abstract class Vehicle
{
    // Grundegenskaper för ALLA fordon och validering
    private string? brand;

    private string? model;
    private int year;
    private double weight;

    public abstract string StartEngine();


    public string Brand
    {
        get
        {
            return brand!;
        }

        set
        {
            // Validering av varumärke som inte får vara null eller tomt och måste vara mellan 2 och 20 tecken
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 20)
                throw new ArgumentException("Brand must be between 2 and 20 characters.");
            brand = value;
        }
    }

    public string Model
    {
        get
        {
            return model!;
        }

        set
        {
            // Validering av modell som inte får vara null eller tomt och måste vara mellan 2 och 20 tecken
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 20)
                throw new ArgumentException("Model must be between 2 and 20 characters.");
            model = value;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }

        set
        {

            // Validering av årtal som måste vara mellan 1886 (det första året för bilar) och det aktuella året och inte vara negativt
            int currentYear = DateTime.Now.Year;
            if (value < 1886 || value > currentYear)
                throw new ArgumentException($"Year must be between 1886 and {currentYear}.");
            year = value;
        }
    }

    public double Weight
    {
        get
        {
            return weight;
        }

        set
        {

            // Validering av vikt som måste vara ett positivt värde
            if (value <= 0)
                throw new ArgumentException("Weight must be a positive value.");
            weight = value;
        }
    }


    //Konstruktorn som är abstrakt och måste implementeras i alla klasser som ärver från Vehicle och returnerar de grundläggande egenskaperna
    public virtual string Stats()
    {
        return $"Brand: {Brand} | Model: {Model} | Year: {Year} | Weight: {Weight}kg ";
    }
}