namespace Garage {
  public class Ram : IGasPowered{
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public void RefuelTank () { System.Console.WriteLine("RAM - Gulp!"); }

    }
  }
