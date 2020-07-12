using Xunit;

namespace BusinessLogic.Tests
{
    public class IntExtensionTest
    {
        [Fact]
        public void AGreaterThanB()
        {
            12.IsGreaterThan(10);
        }

        [Fact]
        public void EverNumber()
        {
            Assert.Equal("Even", 12.OddOrEven());
        }
    }
}
