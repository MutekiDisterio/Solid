namespace Solid_Violation_Examples.LSP
{
    public class ElectricCar : Vehicle ,ICharge
    {
        private const int BATTERY_FULL = 100;
        public int BatteryLevel { get; private set; }
        public void Charge()
        {
            BatteryLevel = BATTERY_FULL;
        }
    }
}
