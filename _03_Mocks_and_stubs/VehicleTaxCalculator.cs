using System;

namespace Vehicles;

public class VehicleTaxCalculator : IVehicleTaxCalculator
{
    public double CalculateTax(IVehicle vehicle)
    {
        return vehicle.Weight * FuelTypeFactor(vehicle.FuelType);
    }

    private double FuelTypeFactor(FuelType fuelType) => fuelType switch
    {
        FuelType.DIESEL => 3,
        FuelType.PETROL => 2,
        FuelType.LPG => 1,
        FuelType.ELECTRIC => 0,
        _ => throw new NotImplementedException(message: "Unkknown fueltype")
    };
}