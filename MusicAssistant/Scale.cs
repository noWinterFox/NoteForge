namespace MusicAssistant;

public abstract class Scale
{
    private static readonly int[] MajorInterval = [2, 2, 1, 2, 2, 2, 1];
    private static readonly int[] MinorInterval = [2, 1, 2, 2, 1, 2, 2];

    private static readonly Dictionary<Mode, int[]> ModeIntervals = new()
    {
        { Mode.Lydian, [2, 2, 2, 1, 2, 2, 1] },
        { Mode.Ionian, MajorInterval },
        { Mode.Major, MajorInterval },
        { Mode.Mixolydian, [2, 2, 1, 2, 2, 1, 2] },
        { Mode.Dorian, [2, 1, 2, 2, 2, 1, 2] },
        { Mode.Aeolian, MinorInterval },
        { Mode.Minor, MinorInterval },
        { Mode.Phrygian, [1, 2, 2, 2, 1, 2, 2] },
        { Mode.Locrian, [1, 2, 2, 1, 2, 2, 2] }
    };

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
        int[] intervals = ModeIntervals.GetValueOrDefault(mode, MajorInterval);
        
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