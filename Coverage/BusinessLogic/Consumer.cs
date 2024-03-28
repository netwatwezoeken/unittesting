namespace BusinessLogic
{
    public class Consumer
    {
        public bool WillBuySnack(bool hungry, int money)
        {
            if(hungry && money > 5)
            {
                return true;
            }
            return false;
        }
    }

}
