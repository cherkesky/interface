﻿using System;
using System.Collections.Generic;

namespace Garage
 {
    //     public class Zero {  // Electric motorcycle
    //     public double BatteryKWh { get; set; }
    //     public string MainColor { get; set; }
    //     public string MaximumOccupancy { get; set; }
        
    //     public void ChargeBattery () { System.Console.WriteLine("Boop"); }
    // }

    // public class Cessna {  // Propellor light aircraft
    // public double FuelCapacity { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }

    // public void RefuelTank () { System.Console.WriteLine("bloop"); }
    // }

    // public class Tesla {  // Electric car
    // public double BatteryKWh { get; set; }
    // public string MainColor { get; set; }
    // public string MaximumOccupancy { get; set; }

    // public void ChargeBattery () { System.Console.WriteLine("TSHIOOOO"); }
    // }

    //     public class Ram {  // Gas powered truck
    //     public double FuelCapacity { get; set; }
    //     public string MainColor { get; set; }
    //     public string MaximumOccupancy { get; set; }

    //     public void RefuelTank () { System.Console.WriteLine("Gulp"); }
    // }

        class Program {
        static void Main (string[] args) {
            Zero fxs = new Zero ();
            Zero fx = new Zero ();
            Tesla modelS = new Tesla ();
            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

            electricVehicles.Add(fx);
            electricVehicles.Add(fxs);
            electricVehicles.Add(modelS);

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();
            List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                ram, cessna150
            };

            gasVehicles.ForEach(gv => gv.RefuelTank());
            electricVehicles.ForEach(ev => ev.ChargeBattery());

        }
    }
}
