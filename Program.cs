using System;

namespace Garage
{
    public class Zero {  // Electric motorcycle
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    
    public void ChargeBattery () { System.Console.WriteLine("Boop"); }
}

    public class Cessna {  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void RefuelTank () { System.Console.WriteLine("bloop"); }
    }

    public class Tesla {  // Electric car
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void ChargeBattery () { System.Console.WriteLine("TSHIOOOO"); }
    }

    public class Ram {  // Gas powered truck
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public void RefuelTank () { System.Console.WriteLine("Gulp"); }
}



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
