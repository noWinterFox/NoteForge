using MusicTheoryLib.Data.Enums;

namespace MusicTheoryLib.Data.Maps.NameMaps;

public class AccidentalNameMapper
{
    public static readonly Dictionary<string, Note> AccidentalNameMap = new()
    {
        { "C#", Note.CSharpDFlat }, { "Db", Note.CSharpDFlat },
        { "D#", Note.DSharpEFlat }, { "Eb", Note.DSharpEFlat },
        { "F#", Note.FSharpGFlat }, { "Gb", Note.FSharpGFlat },
        { "G#", Note.GSharpAFlat }, { "Ab", Note.GSharpAFlat },
        { "A#", Note.ASharpBFlat }, { "Bb", Note.ASharpBFlat }
    };
}