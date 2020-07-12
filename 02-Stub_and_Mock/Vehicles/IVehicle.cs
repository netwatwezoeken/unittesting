namespace Vehicles
{
    public interface IVehicle
    {
        string OwnerEmail { get; }
        int Weight { get; }
        FuelType FuelType { get; }
    }
}