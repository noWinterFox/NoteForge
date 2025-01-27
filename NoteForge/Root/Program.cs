using NoteForge.Classes.Command_Management;
using NoteForge.Classes.Command_Management.Enums;

namespace NoteForge;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        
        while (input != "/close")
        {
            try
            {
                input = Console.ReadLine()!;

                if (input[0] == '/')
                {
                    Command command = CommandParser.Parse(input);
                    CommandExecutor.Execute(command);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}