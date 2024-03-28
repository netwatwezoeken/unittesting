namespace BusinessLogic
{
    public static class IntExtensions
    {
        //public static int Add(this int i, int value)
        //{
        //    return i + value;
        //}

        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static string OddOrEven(this int i)
        {
            return (i % 2 == 0) ? "Even" : "Odd";
        }
    }

}
