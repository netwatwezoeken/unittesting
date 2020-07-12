# 2: Part 1: Stub

1. Open the solution in this directory using Visual Studio
1. Take a look at `VehileTaxCalculator.cs`
1. Add a new Project, choose "xUnit Test Project (.NET Core)"
1. Now fill in the method `Test1` so that it tests tax calculation for a vehicle
    1. Added required project reference
    1. Create a VehileTaxCalculator instance
	1. Add a `VehicleStub` class that implements `IVehicle`
    1. Call it's method `CalculateTax` with an instance of a `VehicleStub`
    1. Check the outcome using `Assert.Equals(....)`
Creating stub manually is not always the quickest way. There are some framworks that can help. Moq is such a framewok.
1. Add the NuGet package Moq
1. Instead of using `VehicleStub` create a stub using Moq: `var vehicleStub = new Mock<IVehicle>();`
1. Call the `CalculateTax` method using `vehicleStub.Object` as parameter
By default this code just runs because a default int is 0 and the default of a enum is it's first value.
However you might want to have the stub return a certain value for this test.
1. Before calling `CalculateTax` add the following `vehicleStub.SetupGet(m => m.Weight).Returns(1500);`
1. Get the test to pass
1. Optionally: add some more testcase by stubbing the FuelType and find the bug.

# 2: Part 2: Mock

1. Continue using the previous solution
1. Take a look at `TaxNotification.cs`
1. Add a new class to test TaxNotifications
1. Two test doubles are required
1. Create a test to verifiy that the result of a tax caluculation is passed to the mailer. Hint: https://github.com/Moq/moq4/wiki/Quickstart#verification