using System;

namespace OnTimeDelivery
{
    interface IVehicle
    {
        double CalculateTravelTime(double travelDistance);
    }

    public abstract class Vehicles : IVehicle
    {
        protected string _vehicleType;
        protected int _milesPerHour;
        public abstract string VehicleType { get; set; }
        public abstract int MilesPerHour { get; set; }
        protected abstract void Vehicle();

        public double CalculateTravelTime(double travelDistance)
        {
            return travelDistance / Convert.ToDouble(_milesPerHour);
        }
    }

    public class Truck : Vehicles
    {
        public override string VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = value;
            }
        }

        public override int MilesPerHour
        {
            get
            {
                return _milesPerHour;
            }
            set
            {
                _milesPerHour = value; 
}
        }

        protected override void Vehicle()
        {
            _vehicleType = "Truck";
            _milesPerHour = 70;
        }

        public Truck()
        {
            Vehicle();
        }
    }

    public class Car : Vehicles
    {
        public override string VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = value;
            }
        }

        public override int MilesPerHour
        {
            get
            {
                return _milesPerHour;
            }
            set
            {
                _milesPerHour = value;
            }
        }

        protected override void Vehicle()
        {
            _vehicleType = "Car";
            _milesPerHour = 50;
        }

        public Car()
        {
            Vehicle();
        }
    }

    public class Bike : Vehicles
    {
        public override string VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = value;
            }
        }

        public override int MilesPerHour
        {
            get
            {
                return _milesPerHour;
            }
            set
            {
                _milesPerHour = value;
            }
        }

        protected override void Vehicle()
        {
            _vehicleType = "Bike";
            _milesPerHour = 10;
        }

        public Bike()
        {
            Vehicle();
        }
    }
}
