using System;

namespace GarysGarage {
    public class Vehicle {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public string Color {get;set;}
        public virtual void Drive () {
        Console.WriteLine("Vrooom!");
    }
    }
}