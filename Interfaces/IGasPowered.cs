namespace GarysGarage
{
    public interface IGasPowered
    {
         double FuelCapacity { get; set; }

         void RefuelTank ();
    }
}