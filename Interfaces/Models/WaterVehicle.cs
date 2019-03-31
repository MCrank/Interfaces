using Interfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    class WaterVehicle : IVehicle, IWaterVehicle
    {
        public int Doors { get ; set ; }
        public int PassengerCapacity { get ; set ; }
        public string TransmissionType { get ; set ; }
        public double EngineVolume { get ; set ; }
        public double MaxSpeed { get ; set ; }

        public void Drive()
        {
            Console.WriteLine($"You drove the vehicle.");
        }

        public void Start()
        {
            Console.Write("You started the vehicle.");
        }

        public void Stop()
        {
            Console.WriteLine("You stopped the vehicle.");
        }
    }
}
