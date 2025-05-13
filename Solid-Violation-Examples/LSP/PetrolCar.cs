namespace Solid_Violation_Examples.LSP
{
    public class PetrolCar : Vehicle, IRefuel
    {
        private const int FUEL_TANK_FULL = 100;
        public int FuelTankLevel { get; private set; } = 0;
        public void Refuel()
        {
            FuelTankLevel = FUEL_TANK_FULL;
        }
   
    }
}
