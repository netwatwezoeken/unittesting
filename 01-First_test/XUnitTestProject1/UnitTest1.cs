using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calculator.Calculator(6);
            calc.Add(5);
            Assert.Equal(11, calc.Value);
        }
    }
}
