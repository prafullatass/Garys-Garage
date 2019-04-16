using System;

namespace GarysGarage {
    public class Cessna : Vehicle, IGasPowered { // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank () {
            Console.WriteLine ("Refill the Gas tank");
        }
        public override void Drive() {
            Console.WriteLine($"The {Color} Cessna zips by you. zzzzzzooooooommmmmmmmmmmmm");
        }
    }
}