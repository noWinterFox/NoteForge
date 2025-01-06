using MusicTheoryLib.Enums;
using MusicTheoryLib.Core;

namespace MusicTheoryLib.Core;

public class CommandHelper
{
    // command execution
    public static void ExecuteCommand(Command command)
    {
        switch (command)
        {
            case Command.Help:
                Facade.ListCommands();
                break;
            
            case Command.Scale:
                Facade.InitiateScale();
                break;
            
            case Command.Chord:
                Facade.InitiateChordGeneration();
                break;
            
            case Command.Close:
                
                break;
        }
    }
}