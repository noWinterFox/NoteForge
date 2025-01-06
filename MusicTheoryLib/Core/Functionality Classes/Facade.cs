using MusicTheoryLib.Enums.Theory;
using MusicTheoryLib.Parsers;
using MusicTheoryLib.Validation;

namespace MusicTheoryLib.Core;

public class Facade
{
    public static void ListCommands()
    {
        Console.WriteLine("/help - Lists all commands");
        Console.WriteLine("/scale - Generates a scale based on a key and mode");
        Console.WriteLine("/chord - Generates a chord based on user input (e.g. \"Cmaj\")");
        Console.WriteLine("/close - Closes the program");
    }

    public static void InitiateScale()
    {
        bool success = false;
        
        // default values because errors
        Note key = Note.C;
        Mode mode = Mode.Major;
        
        while (success == false)
        {
            Console.WriteLine("please input a scale to generate (e.g. \"C Major\")");
        
            try
            {
                string input = Console.ReadLine() ?? throw new ArgumentException("input cannot be empty");

                if (input.Split(" ").Length != 2)
                {
                    throw new ArgumentException("Invalid format, please use the format \"Note Mode\"");
                }
            
                key = NoteParser.ParseNote(input.Split(" ")[0]);
                mode = ModeParser.ParseMode(input.Split(" ")[1]);

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Note[] keyNotes = ScaleGenerator.GenerateScale(key, mode);
        
        Console.Write($"Notes in the {key} {mode} scale: ");
        
        foreach (var note in keyNotes)
        {
            Console.Write($"{note} ");
        }
        
        Console.WriteLine("\n");
    }

    public static void InitiateChordGeneration()
    {
        bool success = false;
        Note root = Note.C;
        ChordType chordType = ChordType.MajorTriad;
        
        while (success == false)
        {
            try
            {
                Console.WriteLine("please input a scale to generate (e.g. \"CMaj\")");

                string input = Console.ReadLine();

                if (input.Substring(0,2).EndsWith("#") || input.Substring(0,2).EndsWith("b"))
                {
                    root = NoteParser.ParseNote(input.Substring(0, 2));
                    input = input.Remove(0, 2);
                }
                else
                {
                    root = NoteParser.ParseNote(input.Substring(0, 1));
                    input = input.Remove(0, 1);
                }

                chordType = ChordTypeParser.ParseChordType(input);

                success = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        List<Note> chordNotes = ChordGenerator.GenerateChord(root, chordType);
        
        Console.Write($"notes in {root}{chordType}: ");
        
        foreach (var note in chordNotes)
        {
            Console.Write($"{note} ");
        }
        
        Console.WriteLine("\n");
    }
}