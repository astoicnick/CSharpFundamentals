using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType{ Car = 1, Truck, Van, Motorcycle, SUV, Minivan, Boat, Plane, Spaceship }


    public class Vehicle
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public double Odometer { get; set; }
        public string Color { get; set; }
        public DateTime TimeOfOwnership { get; set; }
        public string VehicleIdentificationNumber { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; set; }



        public Vehicle() {}

        public Vehicle(string make, int year, string model, double odometer,
            string color, DateTime timeOfOwnership, string vehicleIdentificationNumber)
        {
            Make = make;
            Year = year;
            Model = model;
            Odometer = odometer;
            Color = color;
            TimeOfOwnership = timeOfOwnership;
            VehicleIdentificationNumber = vehicleIdentificationNumber;
        }

        public void StartVehicle()
        {
            IsRunning = true;
        }
        public void StopVehicle()
        {
            IsRunning = false;
        }
        public void DriveVehicle(double distanceTravelled)
        {
            if (IsRunning)
            {
                Odometer += distanceTravelled;
            }
        }

        //private SocialSecurity CreateSSN(string original)
        //{
        //    return new SocialSecurity()
        //    {
        //        Number = original
        //    };
        //}

    }
}
