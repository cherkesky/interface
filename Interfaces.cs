namespace Garage {
    public interface IElectricPowered {
        double BatteryKWh { get; set; }
        void ChargeBattery ();
    }

    public interface IGasPowered {  
      double FuelCapacity  { get; set; }
      void ChargeBattery ();
      void RefuelTank();

    }
}