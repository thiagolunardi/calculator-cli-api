using System.CommandLine;
using System.CommandLine.Invocation;

namespace Calculator.App
{
    public class DivisionCommand : Command
    {
        public static DivisionCommand Create()
            => new DivisionCommand();

        private DivisionCommand() : base("div", "Perform a division")
        {
            AddArgument(new Argument<decimal>("number1"));
            AddArgument(new Argument<decimal>("number2"));

            Handler = CommandHandler.Create<decimal, decimal>(DivisionHandler.Divide);
        }
    }

}
