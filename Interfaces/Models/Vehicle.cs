using Interfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    class Vehicle : IVehicle
    {
        public int Doors { get ; set ; }
        public int PassengerCapacity { get ; set ; }
        public string TransmissionType { get ; set ; }
        public double EngineVolume { get ; set ; }
        public double MaxSpeed { get ; set ; }

        public void Start()
        {
            Console.Write("You started the vehicle");
        }

        public void Stop()
        {
            Console.WriteLine("You stopped the vehicle");
        }
    }
}
