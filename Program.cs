﻿using System;
using System.Collections.Generic;

namespace GarysGarage {
    class Program {
        static void Main (string[] args) {
            Zero fxs = new Zero ();
            Zero fx = new Zero ();
            Tesla modelS = new Tesla ();

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
            Cessna cessna150 = new Cessna ();

            List<IGasPowered> gasVehicles = new List<IGasPowered> () {
                ram,
                cessna150
            };

            gasVehicles.ForEach (gv => gv.RefuelTank ());
            fxs.Drive ();
            modelS.Drive ();
            fx.Drive ();
        }
    }
}