using System;

namespace GarysGarage {
    public class Tesla : IElectricPowered { // Electric car
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void ChargeBattery () {
            Console.WriteLine("Battery is fully charged");
        }
    }

}