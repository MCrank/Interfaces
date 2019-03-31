using System.Linq;
using System;
using System.Collections.Generic;
using Interfaces.Models;

namespace Interfaces
{
    public class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            List<AirVehicle> myAirVehicles = new List<AirVehicle>();
            myAirVehicles.Add(new AirVehicle
            {
                Doors = 2,
                EngineVolume = 7.8,
                MaxSpeed = 257.3,
                PassengerCapacity = 6,
                TransmissionType = "Automatic",
                Wheels = 3,
                Winged = true
            });
            myAirVehicles.Add(new AirVehicle
            {
                Doors = 2,
                EngineVolume = 17.8,
                MaxSpeed = 534.4,
                PassengerCapacity = 187,
                TransmissionType = "Automatic",
                Wheels = 3,
                Winged = true
            });

            // With a single `foreach`, have each vehicle Fly()
            foreach (var airVehicle in myAirVehicles)
            {
                airVehicle.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            List<LandVehicle> myLandVehicles = new List<LandVehicle>();
            myLandVehicles.Add(new LandVehicle
            {
                Doors = 2,
                EngineVolume = 2.3,
                MaxSpeed = 175.5,
                PassengerCapacity = 4,
                TransmissionType = "Automatic",
                Wheels = 4
            });
            myLandVehicles.Add(new LandVehicle
            {
                Doors = 4,
                EngineVolume = 5.3,
                MaxSpeed = 209.3,
                PassengerCapacity = 2,
                TransmissionType = "Manual",
                Wheels = 4
            });
            // With a single `foreach`, have each road vehicle Drive()
            foreach (var landVehicle in myLandVehicles)
            {
                landVehicle.Drive();
            }

            // Build a collection of all vehicles that operate on water
            List<WaterVehicle> myWaterVehicles = new List<WaterVehicle>();
            myWaterVehicles.Add(new WaterVehicle
            {
                Doors = 0,
                EngineVolume = 1.5,
                MaxSpeed = 36,
                PassengerCapacity = 2,
                TransmissionType = "Automatic"
            });
            myWaterVehicles.Add(new WaterVehicle
            {
                Doors = 0,
                EngineVolume = 4.8,
                MaxSpeed = 45,
                PassengerCapacity = 5,
                TransmissionType = "Automatic"
            });
            // With a single `foreach`, have each water vehicle Drive()
            foreach (var waterVehicle in myWaterVehicles)
            {
                waterVehicle.Drive();
            }
            Console.ReadKey();
        }
    }
}