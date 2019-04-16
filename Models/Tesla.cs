using System;

namespace GarysGarage {
    public class Tesla : Vehicle, IElectricPowered { // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            Console.WriteLine ("Battery is fully charged");
        }
        public override void Drive () {
            Console.WriteLine ($"The {Color} Tesla zips by you. Mmmmmmmmmmmmmm!");
        }
        public override void Turn(string direction) {
            Console.WriteLine($"The {Color} Tesla squeals around on {direction} turn");
        }
        public override void Stop() {
            Console.WriteLine($"The {Color} Tesla as it is never moved");
        }
    }

}