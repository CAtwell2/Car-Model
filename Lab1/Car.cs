
using System.Runtime.CompilerServices;

public class Car
{
    //fields
    private string make;
    private string model;
    private int year;
    private double maximumGasTankLevel;
    private double currentGasTankLevel;
    private double milesPerGallon;

    // public properties (getters and setters)
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    //setting parameters around the year to determine if it was a good input or not
    public int Year
    {
        get { return year; }
        set
        {
            if (value >= 1900 && value <= DateTime.Now.Year + 1)
            {
                year = value;
            }
            else
            {
                year = DateTime.Now.Year;
                Console.WriteLine("Invalid year. Year set to current year.");
            }
        }
    }
    //doing the same thing as with the year but this time with the gas levels
    public double MaximumGasTankLevel
    {
        get { return maximumGasTankLevel; }
        set
        {
            if (value >= 0)
            {
                maximumGasTankLevel = value;
            }
            else
            {
                maximumGasTankLevel = 0;
                Console.WriteLine("Invalid maximum gas tank level. Level set to 0.");
            }
        }
    }

    public double CurrentGasTankLevel
    {
        get { return currentGasTankLevel; }
        set
        {
            if (value >= 0)
            {
                currentGasTankLevel = value;
            }
            else
            {
                currentGasTankLevel = 0;
                Console.WriteLine("Invalid current gas tank level. Level set to 0.");
            }
        }
    }
    //letting user input mpg, if it = 0 it will tell them its invalid
    public double MilesPerGallon
    {
        get { return milesPerGallon; }
        set
        {
            if (value >= 0)
            {
                milesPerGallon = value;
            }
            else
            {
                milesPerGallon = 0;
                Console.WriteLine("Invalid miles per gallon. Miles per gallon set to 0.");
            }
        }
    }


    // constructors
    public Car()
    {
        make = "N/A";
        model = "N/A";
        year = DateTime.Now.Year;
        maximumGasTankLevel = 100;
        currentGasTankLevel = 100;
        milesPerGallon = 100;
    }
    //car properties
    public Car(string make, string model, int year, double maximumGasTankLevel, double currentGasTankLevel, double milesPerGallon)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.maximumGasTankLevel = maximumGasTankLevel;
        this.currentGasTankLevel = currentGasTankLevel;
        this.milesPerGallon = milesPerGallon;
    }

    public Car(Car car)
    {
        make = car.make;
        model = car.model;
        year = car.year;
        maximumGasTankLevel = car.maximumGasTankLevel;
        currentGasTankLevel = car.currentGasTankLevel;
        milesPerGallon = car.milesPerGallon;
    }


    //determing how much gas was added and what the new amount would be
    public string FillGasTank(double gallons)
    {
        if (gallons <= 0 || gallons > maximumGasTankLevel - currentGasTankLevel)
        {
            return "Invalid number of gallons.";
        }
        else
        {
            currentGasTankLevel += gallons;
            return "Gas tank filled with " + gallons + " gallons.";
        }
    }

    public bool CanDriveDistance(double distance)
    {
        return (distance / milesPerGallon <= currentGasTankLevel);
    }

    //calculating drive distance and if car has enough gas
    public string Drive(double distance)
    {
        if (CanDriveDistance(distance))
        {
            currentGasTankLevel -= distance / milesPerGallon;
            return "Car drove " + distance + " miles.";
        }
        else
        {
            return "Not enough gas to drive that distance.";
        }
    }

    //calculating what should be returned based on  users input to current gas
    public string Gas()
    {
        double gasPercentage = currentGasTankLevel / maximumGasTankLevel;
        if (gasPercentage == 1)
        {
            return "Full tank";
        }
        else if (gasPercentage == 0.75)
        {
            return "3/4 tank";
        }
        else if (gasPercentage == 0.5)
        {
            return "1/2 tank";
        }
        else if (gasPercentage == 0.25)
        {
            return "1/4 tank";
        }
        else if (gasPercentage > 0)
        {
            return currentGasTankLevel + " out of " + maximumGasTankLevel + " gallons remaining";
        }
        else if (gasPercentage <= 0)
        {
            return "Empty tank";
        }
        else
        {
            return "";
        }

    }
}