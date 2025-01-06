using MusicTheoryLib.Enums;
using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Parsers;

public class CommandParser
{
    public static Command ParseCommand(string command)
    {
        if (string.IsNullOrEmpty(command) || command[0] != '/')
        {
            throw new ArgumentException("Command must start with '/' and cannot be empty.", nameof(command));
        }

        // Remove the leading '/'
        command = command.Substring(1);

        // Validate and parse the command
        if (!Enum.TryParse<Command>(command, true, out var parsedCommand))
        {
            throw new ArgumentException($"Invalid command: '{command}'.", nameof(command));
        }

        return parsedCommand;
    }
}
