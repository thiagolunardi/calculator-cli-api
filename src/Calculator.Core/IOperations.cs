namespace Calculator.Core
{
    public interface IOperations
    {
        decimal Add(decimal number1, decimal number2);
        decimal Divide(decimal number1, decimal number2);
        decimal Sub(decimal number1, decimal number2);
        decimal Times(decimal number1, decimal number2);
    }
}