namespace Solid_Violation_Examples.LSP
{
    public class FillingStation
    {
        public static void Refuel(IRefuel vehicle)
        {
            vehicle.Refuel();
        }
        public static void Charge(ICharge vehicle)
        {
            vehicle.Charge();
        }
    }
}
