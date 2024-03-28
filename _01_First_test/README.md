# 1: First test

1. Take a look at what `Calculator.cs` does
1. Add a new Project, choose "xUnit Test Project (.NET Core)" use `Calculator.Test` as name
1. Now fill in the method `Test1` so that it tests addition of two numbers:
    1. Add a project reference to `_01_First_test`
    1. In Test1() create a Calculator instance
    1. Call it's method `Add`
    1. Check the outcome using `Assert.Equal(....)`
1. Build everything and run the unit test
    * Right click on the Class then `Run Test(s)`
    * or by opening Visual Studio's Test Explorer Or Rider's test pane
    * run `dotnet test` from within the unittest project folder
1. Debugging is also possible. Set a break point and run the test in debug mode
1. Optionaly add some more test methods to further test the Calculator class
