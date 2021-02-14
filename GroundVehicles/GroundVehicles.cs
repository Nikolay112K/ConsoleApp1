using System;
using Vehicle;

namespace GroundVehicles
{
    public class KickScooter : TechnicalVehicle
    {

    }
    public class Bike : TechnicalVehicle
    {

    }
    public class Moped : TechnicalVehicle
    {

    }
    public class Motorcycle : TechnicalVehicle
    {

    }
    public class Scooter : TechnicalVehicle
    {

    }
    public class Car : TechnicalVehicle
    {
        public string EngineHealth;
        public string Transmission;
        public int Doors;
        public double Odometer;
        public byte Seats;
        public bool Roof;
        public bool WaterProof;
        public double MaxSpeed;
        public int Wheels;
        public double Tank;
        public Car() { EngineHealth = "Unknown"; Transmission = "Unknown"; Doors = 2; Odometer = 0; Seats = 2; Roof = true; WaterProof = true; MaxSpeed = 100; Wheels = 4; Tank = 1.5; }
        public void CarCrash()
        {
            string engineHealth = EngineHealth;
            string transmission = Transmission;
            int doors = Doors;
            byte seats = Seats;
            bool roof = Roof;
            bool waterProof = WaterProof;
            double maxSpeed = MaxSpeed;
            int wheels = Wheels;
            double tank = Tank;

        }

    }
    public class AllTerrainVehicle : TechnicalVehicle
    {

    }
    public class Train : TechnicalVehicle
    {

    }
    public class Trolleybus : TechnicalVehicle
    {

    }
    public class Trum : TechnicalVehicle
    {

    }
    public class Bus : TechnicalVehicle
    {

    }
}
