using System.Threading.Tasks;

namespace Calculator.App
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
            services


            var root = new CalculatorCommandLine();

            return await root.Invoke(args);
        }
    }
}
