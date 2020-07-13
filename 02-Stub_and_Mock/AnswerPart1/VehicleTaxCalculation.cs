using Moq;
using System;
using System.Collections.Generic;
using Vehicles;
using Xunit;

namespace Part1
{
    public class VehicleTaxCalculation
    {
        [Fact]
        public void Returns4200ForDieselThatWeighs1400()
        {
            var vehicleTaxCalculator = new VehicleTaxCalculator();
            Assert.Equal(4200, vehicleTaxCalculator.CalculateTax(new VehicleStub()));
        }

        [Fact]
        public void Returns3000ForPetrolThatWeighs1500()
        {
            var vehicleStub = new Mock<IVehicle>();
            vehicleStub.SetupGet(m => m.FuelType).Returns(FuelType.PETROL);
            vehicleStub.SetupGet(m => m.Weight).Returns(1500);
            var vehicleTaxCalculator = new VehicleTaxCalculator();
            Assert.Equal(3000, vehicleTaxCalculator.CalculateTax(vehicleStub.Object));
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void HandlesAllFueltTypes(FuelType fuelType)
        {
            var vehicleStub = new Mock<IVehicle>();
            vehicleStub.SetupGet(m => m.FuelType).Returns(fuelType);
            var vehicleTaxCalculator = new VehicleTaxCalculator();
            vehicleTaxCalculator.CalculateTax(vehicleStub.Object);
        }

        public static IEnumerable<object[]> EnumValues()
        {
            foreach (var thing in Enum.GetValues(typeof(FuelType)))
            {
                yield return new object[] { thing };
            }
        }
    }
}
