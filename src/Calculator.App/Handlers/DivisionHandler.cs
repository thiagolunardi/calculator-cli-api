using System;
using Calculator.Core;

namespace Calculator.App
{
    public class DivisionHandler : AbstractHandler
    {
        public DivisionHandler(IOperations operations) 
            : base(operations)
        {
        }

        public void Divide(decimal number1, decimal number2)
            => Console.WriteLine($"={Operations.Divide(number1, number2)}");
    }
}
