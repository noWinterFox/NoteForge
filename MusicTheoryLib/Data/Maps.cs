namespace MusicTheoryLib.Data;

public class Maps
{
    // Mapping for accidentals (sharp/flat) to standardized note names
    public static readonly Dictionary<string, string?> NoteMapping = new(StringComparer.OrdinalIgnoreCase)
    {
        { "A#", "ASharpBFlat" }, { "Bb", "ASharpBFlat" },
        { "C#", "CSharpDFlat" }, { "Db", "CSharpDFlat" },
        { "D#", "DSharpEFlat" }, { "Eb", "DSharpEFlat" },
        { "F#", "FSharpGFlat" }, { "Gb", "FSharpGFlat" },
        { "G#", "GSharpAFlat" }, { "Ab", "GSharpAFlat" }
    };
}