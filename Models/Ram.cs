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
         public override void Turn(string direction) {
            Console.WriteLine($"The {Color} Ram carefully turn {direction}.");
        }
        public override void Stop() {
            Console.WriteLine($"The {Color} Ram gently stops!");
        }
    }
}