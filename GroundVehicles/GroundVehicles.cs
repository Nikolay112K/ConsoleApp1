﻿using System;
using Vehicle;

namespace GroundVehicles
{
    public class KickScooter : TechnicalVehicle
    {
        public string MotorHealth;
        public int NumberOfWheels;
    }
    public class Bike : TechnicalVehicle
    {
        public int Wheels;
        public int Gears;
        public int Seat;
        public string RamHealth;
        public int Pedals;
        public string ChainHealth;
        public string SpokesHealth;
        public int Tire;
    }
    public class Moped : TechnicalVehicle
    {
        public string Engine;
        public int Seat;
        public int Trunk;
        public int Gear;
    }
    public class Motorcycle : TechnicalVehicle
    {
        public string Engine;
        public int Seat;
        public int Trunk;
        public int Gear;
    }
    public class Scooter : TechnicalVehicle
    {
        public string EngineHealth;
        public int Seat;
        public int Trunk;
        public int Gear;

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
            if (WillTheCarStart == true)
            {
                DistanceInKM = MaxSpeed / TankCapacity;
                Console.WriteLine($"How many kilometers this car will go? :{DistanceInKM}");
            }

        }

    }
    public class AllTerrainVehicle : TechnicalVehicle
    {
        public string CaterpillarsHealth;
        public string EngineHealth;
        public int Windows;
        public int Door;
        public int Light;
    }
    public class Train : TechnicalVehicle
    {
        public string EngineHealth;
        public string InductorMagneticFieldsHealth;
        public string MetalStripHealth;
        public int Light;
        public int Carriage;
        public string RamHealth;
    }
    public class Trolleybus : TechnicalVehicle
    {
        public string DCMotorHealth;
        public int Window;
        public int WheelHealth;
        public string ArrowHealth;
        public string EngineHealth;
        public string BodyHealth;
        public int Seats;
        public int Mirrors;
        public int Lights;

    }
    public class Trum : TechnicalVehicle
    {
        public string EngineHealth;
        public int Seats;
        public string BodyHealth;
        public int Lights;
    }
    public class Bus : TechnicalVehicle
    {
        public string EngineHealth;
        public int Seats;
        public string BodyHealth;
        public int Wheels;
        public int Lights;
        public string MirrorsHealth;
    }
}
