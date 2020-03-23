using System.CommandLine;
using System.CommandLine.Invocation;

namespace Calculator.App
{
    public class SubstractionCommand : Command
    {
        public static SubstractionCommand Create()
            => new SubstractionCommand();

        private SubstractionCommand() : base("subs", "Perform a substraction")
        {
            AddArgument(new Argument<decimal>("number1"));
            AddArgument(new Argument<decimal>("number2"));

            Handler = CommandHandler.Create<decimal, decimal>(SubstractionHandler.Sub);
        }
    }
}
