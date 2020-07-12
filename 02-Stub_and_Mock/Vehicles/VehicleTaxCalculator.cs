using System;

namespace Vehicles
{
    public class VehicleTaxCalculator : IVehicleTaxCalculator
    {
        public int CalculateTax(IVehicle vehicle)
        {
            return vehicle.Weight * FuelTypeFactor(vehicle.FuelType);
        }

        private int FuelTypeFactor(FuelType fuelType)
        {
            int ret;
            switch (fuelType)
            {
                case FuelType.DIESEL: ret = 3; break;
                case FuelType.PETROL: ret = 2; break;
                case FuelType.LPG: ret = 1; break;
                case FuelType.ELECTRIC: ret = 0; break;
                default: throw new NotImplementedException(message: "enum value not handled");
            }
            return ret;
        }
    }
}