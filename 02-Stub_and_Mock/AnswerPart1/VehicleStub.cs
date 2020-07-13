using Vehicles;

namespace Part1
{
    public class VehicleStub : IVehicle
    {
        public string OwnerEmail => "jos@netwatwezoeken.nl";

        public int Weight => 1400;

        public FuelType FuelType => FuelType.DIESEL;
    }
}
