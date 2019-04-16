using System;

namespace GarysGarage {
    public class Tesla : Vehicle, IElectricPowered { // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            Console.WriteLine ("Battery is fully charged");
        }
        public override void Drive () {
            Console.WriteLine ("Zoooooom!");
        }
    }

}