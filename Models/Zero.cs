using System;

namespace GarysGarage {
    public class Zero : Vehicle, IElectricPowered{ // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {
            Console.WriteLine("Battery is fully charged");
         }
         public override void Drive() {
             Console.WriteLine($"The {Color} Zero zips by you. Yeeeeeeeeeeoooooooowwwwwwww");
         }
         public override void Turn(string direction) {
             Console.WriteLine($"The {Color} Zero silently tuned {direction}");
         }
         public override void Stop() {
             Console.WriteLine($"The {Color} Zero gently rolls to stop");
         }
    }
}