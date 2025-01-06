using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Parsers;

public class ChordTypeParser
{
    public static ChordType ParseChordType(string chordtype)
    {
        if (Enum.TryParse(chordtype, true, out ChordType parsedChordType) && Enum.IsDefined(typeof(ChordType), parsedChordType))
        {
            return parsedChordType;
        }

        throw new ArgumentException($"\"{chordtype}\" is not a valid chord type");
    }
}