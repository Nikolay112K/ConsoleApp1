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
        public double TankCapacity;
        public string QualityOfSparkPlug;
        public byte BatteryChargeInPercent;
        public Car() : this("Unknown", "Unknown", 2, 0, 2, true, true, 100, 4, 1.5, "100", 100) { }
        public Car(string EngineHealth, string Transmission, int Doors, double Odometer, byte Seats, bool Roof, bool WaterProof, double MaxSpeed, int Wheels, double TankCapacity, string QualityOfSparkPlug, byte BatteryChargeInPercent)
        {
            this.EngineHealth = EngineHealth;
            this.Transmission = Transmission;
            this.Odometer = Odometer;
            this.Doors = Doors;
            this.Seats = Seats;
            this.Roof = Roof;
            this.WaterProof = WaterProof;
            this.MaxSpeed = MaxSpeed;
            this.Wheels = Wheels;
            this.TankCapacity = TankCapacity;
            this.QualityOfSparkPlug = QualityOfSparkPlug;
            this.BatteryChargeInPercent = BatteryChargeInPercent;
        }
        public void CarTesting()
        {
            bool WillTheCarStart;
            double DistanceInKM;

            if (QualityOfSparkPlug == "100" && BatteryChargeInPercent == 100)
            {
                WillTheCarStart = true;
                Console.WriteLine($"Will The car Start? :{WillTheCarStart}");
            }
            else
            {
                WillTheCarStart = false;
                Console.WriteLine($"Will The car Start? :{WillTheCarStart}");
            }
            if (true)
            {
                DistanceInKM = MaxSpeed / TankCapacity;
                Console.WriteLine($"How many kilometers this car will go? :{DistanceInKM}");
            }
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
