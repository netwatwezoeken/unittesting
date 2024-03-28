# Part 1: Stub

1. Open the solution in this directory using Visual Studio
1. Take a look at `VehileTaxCalculator.cs`
1. Add a new Project, choose "xUnit Test Project (.NET Core)"
1. Now fill in the method `Test1` so that it tests tax calculation for a vehicle
    1. Added required project reference
    1. Create a VehileTaxCalculator instance
	1. Add a `VehicleStub` class that implements `IVehicle`
    1. Call `CalculateTax` on the calculator with an instance of the newly created `VehicleStub`
    1. Check the outcome using `Assert.Equals(....)`

Creating stub manually is not always the quickest way. There are some frameworks that can help. Moq is such a framewok.
1. Add the NuGet package NSubstitute
1. Instead of using `VehicleStub` create a stub using Moq: `var vehicleStub = new Substitute.For<IVehicle>();`
1. Call the `CalculateTax` method using `vehicleStub` as parameter

By default this code works because NSubstitute returns the default value unless configured otherwise. The default of `int` and `double` is 0 and the default of a `enum` is it's first value.
However you might want to have the stub return a certain value for this test.
1. Before calling `CalculateTax` add the following `vehicleStub.Weight.Returns(1500);`
1. Adjust the `Assert.Equals(....)` to check the expected result.
1. Optionally: add some more testcase by stubbing the FuelType and find the bug.

# Part 2: Mock

1. Continue using the previous solution
1. Take a look at `TaxNotification.cs`
1. Add a new class to test TaxNotifications
1. Two test doubles are required
1. Create a test to verify that the result of a tax calculation is passed to the mailer. Hint: https://nsubstitute.github.io/help/received-calls/
