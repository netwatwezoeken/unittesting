using Calculator;

namespace _01_First_test_Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var sut = new Calculator.Calculator();
        sut.Add(4);
        Assert.Equal(4, sut.Value);
    }
}