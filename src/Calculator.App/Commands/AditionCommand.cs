using System.CommandLine;
using System.CommandLine.Invocation;

namespace Calculator.App
{
    public class AditionCommand : Command
    {
        public static AditionCommand Create()
            => new AditionCommand();

        private AditionCommand() : base("add", "Perform an adition")
        {
            AddArgument(new Argument<decimal>("number1"));
            AddArgument(new Argument<decimal>("number2"));

            Handler = CommandHandler.Create<decimal, decimal>(AditionHandler.Add);
        }
    }
}
