namespace Interfaces.Contracts
{
    public interface IAirVehicle
    {
        // an int property called Wheels 
        int Wheels { get; set; }

        // a bool property called Winged 
        bool Winged { get; set; }

        // a method called Fly() that returns void
        void Fly();
    }
}
