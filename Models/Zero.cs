using System;

namespace GarysGarage {
    public class Zero : Vehicle, IElectricPowered{ // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            Console.WriteLine("Battery is fully charged");
         }
    }
}