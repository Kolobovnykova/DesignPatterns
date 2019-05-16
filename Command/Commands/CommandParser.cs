using System.Collections.Generic;
using System.Linq;

namespace Command.Commands
{
    class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];
            var command = FindRequestedCommand(requestedCommandName);

            return command.MakeCommand(args);
        }

        ICommandFactory FindRequestedCommand(string name)
        {
            return availableCommands.FirstOrDefault(
                cmd => cmd.CommandName == name);
        }
    }
}
