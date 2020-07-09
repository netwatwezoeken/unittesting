namespace Calculator
{
    public class Calculator
    {
        public int Value { get; private set; }

        public Calculator(int value = 0)
        {
            Value = value;
        }

        public void Reset()
        {
            Value = 0;
        }

        public void Add(int addValue)
        {
            Value += addValue;
        }

        public void Substract(int substractValue)
        {
            Value -= substractValue;
        }
    }
}
