using System;
using Calculator.Core;

namespace Calculator.App
{
    public class AditionHandler : AbstractHandler
    {
        public AditionHandler(IOperations operations) 
            : base(operations)
        {
        }

        public void Add(decimal number1, decimal number2)
            => Console.WriteLine($"={Operations.Add(number1, number2)}");
    }
}
