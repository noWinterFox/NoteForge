using System.Data;
using NoteForge.Classes.Command_Management.Enums;

namespace NoteForge.Classes.Command_Management;

public class CommandExecutor
{
    public static void Execute(Command command)
    {
        switch (command)
        {
            case Command.Help:
                Console.WriteLine("Executing command help...");
                
                foreach (Enum commandType in Enum.GetValues(typeof(Command)))
                {
                    Console.WriteLine(Enum.GetName(typeof(Command), commandType));
                }
                
                Console.WriteLine("command help executed.");
                
                break;
        }
    }
}