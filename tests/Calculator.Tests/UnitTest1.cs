using System.CommandLine;
using System.CommandLine.Builder;
using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class UnitTest1
    {
            [Fact]
        public void AllCommandsAreValid()
        {
            var cmdBuilder = GetCmdBuilder();

            var rootCommand = cmdBuilder.Command;

            AssertSubCommandsAreValid(rootCommand);
        }

        private CommandLineBuilder GetCmdBuilder()
            => Startup.CreateCmdBuilder(
                _handlers.GetAbesences,
                _handlers.GetPaygrades,
                _handlers.GetBookingBehavior,
                _handlers.GetEmployees);

        private void AssertSubCommandsAreValid(ICommand command)
        {
            command.Description.Should()
                .NotBeNullOrEmpty($"Command {command.Name} has no description.");

            foreach (var option in command.Options)
            {
                option.Description.Should()
                    .NotBeNullOrEmpty($"Command option {command.Name} {option.Name} has no description.");
            }

            var subCommands = command.Children
                .Where(child => child is ICommand)
                .ToArray();

            foreach (var subCommand in subCommands)
            {
                AssertSubCommandsAreValid((ICommand)subCommand);
            }

            if (subCommands.Length == 0)
            {
                (command as Command).Handler.Should()
                    .NotBeNull($"Command {command.Name} has no children nor handler.");
            }
        }
    }
}
