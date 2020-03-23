using System;
using Calculator.Core;

namespace Calculator.App
{
    public class SubstractionHandler : AbstractHandler
    {
        public SubstractionHandler(IOperations operations) 
            : base(operations)
        {
        }

        public void Sub(decimal number1, decimal number2)
            => Console.WriteLine($"={Operations.Sub(number1, number2)}");
    }
}
