using MusicTheoryLib.Data;
using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Core;

public class ScaleGenerator
{
    public static readonly Dictionary<Note, Note[]> KeyScales = new()
    {
        { Note.A, GenerateScale(Note.A) },
        { Note.ASharpBFlat, GenerateScale(Note.ASharpBFlat) },
        { Note.B, GenerateScale(Note.B) },
        { Note.C, GenerateScale(Note.C) },
        { Note.CSharpDFlat, GenerateScale(Note.CSharpDFlat) },
        { Note.D, GenerateScale(Note.D) },
        { Note.DSharpEFlat, GenerateScale(Note.DSharpEFlat) },
        { Note.E, GenerateScale(Note.E) },
        { Note.F, GenerateScale(Note.F) },
        { Note.FSharpGFlat, GenerateScale(Note.FSharpGFlat) },
        { Note.G, GenerateScale(Note.G) },
        { Note.GSharpAFlat, GenerateScale(Note.GSharpAFlat) }
    };
    
    public static Note[] GenerateScale(Note key, Mode mode = Mode.Major)
    {
        // if no specified mode, default to major
        int[] intervals = Intervals.ModeIntervals.GetValueOrDefault(mode, Intervals.ModeIntervals[mode]);
        
        Note[] keyNotes = new Note[7];
        Note currentNote = key;

        // Generate the scale based on the intervals
        for (int i = 0; i < intervals.Length; i++)
        {
            keyNotes[i] = currentNote;
            currentNote = (Note)(((int)currentNote + intervals[i]) % Enum.GetValues(typeof(Note)).Length); // Wrap around notes
        }

        return keyNotes;
    }
}