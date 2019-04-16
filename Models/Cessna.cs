using System;

namespace GarysGarage {
    public class Cessna : IGasPowered { // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void RefuelTank () {
            Console.WriteLine ("Refill the Gas tank");
        }
    }
}