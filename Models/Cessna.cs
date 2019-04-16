using System;

namespace GarysGarage {
    public class Cessna : Vehicle, IGasPowered { // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank () {
            Console.WriteLine ("Refill the Gas tank");
        }
    }
}