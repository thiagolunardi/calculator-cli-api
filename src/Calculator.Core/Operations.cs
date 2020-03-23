namespace Calculator.Core
{
    public class Operations : IOperations
    {
        public decimal Add(decimal number1, decimal number2)
            => number1 + number2;

        public decimal Sub(decimal number1, decimal number2)
            => number1 - number2;

        public decimal Times(decimal number1, decimal number2)
            => number1 * number2;

        public decimal Divide(decimal number1, decimal number2)
            => number1 / number2;
    }
}