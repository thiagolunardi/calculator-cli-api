using Calculator.Core;

namespace Calculator.App
{
    public abstract class AbstractHandler
    {
        protected readonly IOperations Operations;

        protected AbstractHandler(IOperations operations)
            => Operations = operations;
    }
}