using System.CommandLine;
using System.CommandLine.Invocation;

namespace Calculator.App
{
    public class MultiplicationCommand : Command
    {
        public static MultiplicationCommand Create()
            => new MultiplicationCommand();

        private MultiplicationCommand() : base("times", "Perform an multiplication")
        {
            AddArgument(new Argument<decimal>("number1"));
            AddArgument(new Argument<decimal>("number2"));

            Handler = CommandHandler.Create<decimal, decimal>(MultiplicationHandler.Times);
        }
    }
}
