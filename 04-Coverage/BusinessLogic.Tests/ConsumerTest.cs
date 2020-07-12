using Xunit;
using BusinessLogic;

namespace BusinessLogic.Tests
{
    public class Hungry_Consumer_With_Enough_Money
    {
        [Fact]
        public void Will_Buy_Snack()
        {
            Assert.True(new Consumer().WillBuySnack(true, 6));
        }
    }

    public class Hungry_Consumer_Without_Enough_Money
    {
        [Fact]
        public void Will_Not_Buy_Snack()
        {
            Assert.False(new Consumer().WillBuySnack(true, 4));
        }
    }
}
