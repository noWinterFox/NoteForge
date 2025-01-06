using MusicTheoryLib.Data;
using MusicTheoryLib.Enums;
using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Parsers;

public class NoteParser
{
    public static Note ParseNote(string note)
    {
        // Check if the note exists in the Maps and parse accordingly
        if (Maps.NoteMapping.TryGetValue(note, out string? enumName))
        {
            if (Enum.TryParse(enumName, true, out Note parsedNote) && Enum.IsDefined(typeof(Note), parsedNote))
            {
                return parsedNote;
            }
        }
        else
        {
            // Try to parse the note directly if not an accidental
            if (Enum.TryParse(note, true, out Note parsedNote) && Enum.IsDefined(typeof(Note), parsedNote))
            {
                return parsedNote;
            }
        }

        throw new ArgumentException($"\"{note}\" is not a valid note");
    }
}