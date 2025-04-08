using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager.Vehicles;

public abstract class Vehicle
{
    // Grundegenskaper för ALLA fordon
    private string brand;
    private string model;
    private int year;
    private double weight;

    public string Brand
    {
        get
        {
            return brand;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 20)
                throw new ArgumentException("Brand must be between 2 and 20 characters.");
            brand = value;
        }
    }

    public string Model
    {
        get
        {
            return model;
        }

        set
        {
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
            if (value <= 0)
                throw new ArgumentException("Weight must be a positive value.");
            weight = value;
        }
    }
}
