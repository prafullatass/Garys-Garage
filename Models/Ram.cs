using System;

namespace GarysGarage {
    public class Ram : Vehicle, IGasPowered{ // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank () {
            Console.WriteLine("Refill the Gas tank");
        }
        public override void Drive() {
            Console.WriteLine($"The {Color} Ram zips by you. Rrrrruuuummmbbbblllllleeeeeeeeeeeee");
        }
    }
}