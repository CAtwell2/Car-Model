


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        // make a default Car and display it to the console



        // asks the user for their car's information, creates the car, and displays it to the console

        Console.WriteLine("------------Default Car--------------");
        Console.WriteLine("Make: N/A");
        Console.WriteLine("Model: N/A");
        Console.WriteLine("Year:" + DateTime.Now.Year);
        Console.WriteLine("Max Gas: 100");
        Console.WriteLine("Current Gas: 100");
        Console.WriteLine("Miles Per Gallon: 100");


        Console.WriteLine("-------------Users Car-------------");
        Console.Write("Enter your car's make: ");
        string make = Console.ReadLine();
        Console.Write("Enter your car's model: ");
        string model = Console.ReadLine();
        Console.Write("Enter your car's year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter your car's max gas tank level: ");
        double maximumGasTankLevel = double.Parse(Console.ReadLine());
        Console.Write("Enter your car's current gas tank level: ");
        double currentGasTankLevel = double.Parse(Console.ReadLine());
        Console.Write("Enter your car's miles per gallon: ");
        double milesPerGallon = double.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------------");
        
        Car userCar = new Car (make, model, year, maximumGasTankLevel, currentGasTankLevel, milesPerGallon);
        Console.WriteLine("Make: " + make);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Maximum Gas Tank Level: " + maximumGasTankLevel);
        Console.WriteLine("Current Gas Tank Level: " + currentGasTankLevel);
        Console.WriteLine("Miles Per Gallon: " + milesPerGallon);


        // display a menu to the user asking what they would like to do next
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("What would you like to do next?\n1. Travel to Kingsport (25 Miles)\n2. Travel to Knoxville (108 Miles)\n3. Specify distance to travel\n4. Check on car details\n5. Fill gas tank\n6. Quit program");
            Console.WriteLine("--------------------------");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(userCar.Drive(25));
                    break;
                case 2:
                    Console.WriteLine(userCar.Drive(108));
                    break;
                case 3:
                    Console.WriteLine("Enter distance to travel: ");
                    double distance = double.Parse(Console.ReadLine());
                    Console.WriteLine(userCar.Drive(distance));
                    break;
                case 4:
                    Console.WriteLine("Make: " + make);
                    Console.WriteLine("Model: " + model);
                    Console.WriteLine("Year: " + year);
                    Console.WriteLine("Maximum Gas Tank Level: " + maximumGasTankLevel);
                    Console.WriteLine("Current Gas Tank Level: " + currentGasTankLevel);
                    Console.WriteLine("Miles Per Gallon: " + milesPerGallon);
                    break;
                case 5:
                    Console.WriteLine("Enter gallons to fill: ");
                    double gallons = double.Parse(Console.ReadLine());
                    Console.WriteLine(userCar.FillGasTank(gallons));
                    break;
                case 6:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}