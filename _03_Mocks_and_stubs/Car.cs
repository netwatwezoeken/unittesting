namespace Vehicles;

public class Car : IVehicle
{
    private readonly DriveTrain _driveTrain;
    private readonly string _color;

    public Car(DriveTrain driveTrain, string color, int weigth, FuelType fuelType, string ownerEmail)
    {
        _driveTrain = driveTrain;
        _color = color;
        Weight = weigth;
        FuelType = fuelType;
        OwnerEmail = ownerEmail;
    }

    public override string ToString()
    {
        return $"This is a {_color} {_driveTrain} Car.";
    }

    public int Weight { get; }

    public FuelType FuelType { get; }

    public string OwnerEmail { get; }
}