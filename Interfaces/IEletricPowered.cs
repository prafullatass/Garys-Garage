using System;

namespace GarysGarage
{
    public interface IElectricPowered {
        double BatteryKWh {get;set;}

        void ChargeBattery ();
    }
}