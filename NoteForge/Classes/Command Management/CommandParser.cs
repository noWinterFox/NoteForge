using NoteForge.Classes.Command_Management.Enums;

namespace NoteForge.Classes.Command_Management;

public abstract class CommandParser
{
    public static Command Parse(string command)
    {
        string parsedCommand = command[1].ToString().ToUpper() + command[2..].ToLower();

        if (Enum.IsDefined(typeof(Command), parsedCommand))
        {
            if (Enum.TryParse(parsedCommand, true, out Command commandEnum))
            {
                return commandEnum;
            }
            
            throw new ArgumentException($"failed to parse command: {parsedCommand}");
        }
        
        throw new ArgumentException($"invalid command: {command}");
    }
}