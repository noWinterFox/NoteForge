using MusicTheoryLib.Core;
using MusicTheoryLib.Parsers;
using MusicTheoryLib.Validation;

namespace MusicAssistant;

class Program
{
    private static bool IsRunning = true;
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the NoteForge! \n type /help to list all the commands");
        
        string input;
        
        while (IsRunning)
        {
            input = Console.ReadLine();

            if (InputValidation.IsValidCommand(input))
            {
                CommandHelper.ExecuteCommand(CommandParser.ParseCommand(input));
            }
        }
    }
}
