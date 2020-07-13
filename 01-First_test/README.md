# 1: First test

1. Open the solution in this directory using Visual Studio
1. Take a look at what the code does
1. Add a new Project, choose "xUnit Test Project (.NET Core)" use `Calculator.Test` as name
1. Now fill in the method `Test1` so that it tests addition of two numbers
    1. Added required project reference
    1. Create a Calculator instance
    1. Call it's method `Add`
    1. Check the outcome using `Assert.Equal(....)`
1. Build everything and run the unit test
    * By pressing `Ctrl + R, T`
    * or right click on the Class then `Run Test(s)`
    * or by opening Visual Studio's Test Explorer
1. Debugging is also possible. Set a break point and run the test in debug mode
1. Optionaly add some more test methods to further test the Calculator class
