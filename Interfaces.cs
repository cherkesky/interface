namespace Garage {
    public interface IElectricPowered {
        double BatteryKWh { get; set; }

        void ChargeBattery ();
    }
}