using System;
using Calculator.Core;

namespace Calculator.App
{
    public class MultiplicationHandler : AbstractHandler
    {
        public MultiplicationHandler(IOperations operations) 
            : base(operations)
        {
        }

        public void Times(decimal number1, decimal number2)
            => Console.WriteLine($"={Operations.Times(number1, number2)}");
    }
}
