using System;
using System.Collections.Generic;

namespace GarysGarage {
    class Program {
        static void Main (string[] args) {
            Zero fxs = new Zero ();
            Zero fx = new Zero ();
            Tesla modelS = new Tesla ();
            fxs.Color = "Midnight Blue";
            fx.Color = "Red";
            modelS.Color = "Black";
            /*
                This can only hold individual motorcycles. You can't
                add the Tesla to this list. It's a different type.
                This is invalid code. The `modelS` is not of type Zero.
            */
            //List<Zero> electricVehicles = new List<Zero> () { fx, fxs, modelS };

            List<IElectricPowered> electricVehicles = new List<IElectricPowered> ();

            electricVehicles.Add (fx);
            electricVehicles.Add (fxs);
            electricVehicles.Add (modelS);

            electricVehicles.ForEach (gv => gv.ChargeBattery ());

            /*
                Create some gas vehicles, add them to a List
                and then iterate the List to fill all of their
                fuel tanks.
            */
            Ram ram = new Ram ();
            ram.Color = "Silver";
            Cessna cessna150 = new Cessna ();
            cessna150.Color = "Maroon";

            List<IGasPowered> gasVehicles = new List<IGasPowered> () {
                ram,
                cessna150
            };

            gasVehicles.ForEach (gv => gv.RefuelTank ());
            fxs.Drive ();
            fxs.Turn("Left");
            fxs.Stop();

            modelS.Drive ();
            modelS.Turn("Left");
            modelS.Stop();

            fx.Drive ();
            fx.Turn("Right");
            fx.Stop();

            ram.Drive();
            ram.Turn("Left");
            ram.Stop();

            cessna150.Drive();
            cessna150.Turn("Left");
            cessna150.Stop();


        }
    }
}