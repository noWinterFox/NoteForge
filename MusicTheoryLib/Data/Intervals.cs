using MusicTheoryLib.Enums;
using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Data;

public class Intervals
{
    private static readonly int[] MajorInterval = [2, 2, 1, 2, 2, 2, 1];
    private static readonly int[] MinorInterval = [2, 1, 2, 2, 1, 2, 2];

    public static readonly Dictionary<Mode, int[]> ModeIntervals = new()
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

    public static readonly Dictionary<ChordType, string[]> ChordIntervals = new()
    {
        { ChordType.MajorTriad, ["1", "3", "5"] }, // index + 1
        { ChordType.MinorTriad, ["1", "3b", "5"] },
        { ChordType.DiminishedTriad, ["1", "3b", "5b"] },
        
        { ChordType.AugmentedTriad, ["1", "3", "5#"] },
        { ChordType.Sus2, ["1", "2", "5"] },
        { ChordType.Sus4, ["1", "4", "5"] },
        
        { ChordType.Major7, ["1", "3", "5", "7"] },
        { ChordType.Minor7, ["1", "3b", "5", "7b"] },
        { ChordType.Dominant7, ["1", "3", "5", "7b"] },
        { ChordType.Diminished7, ["1", "3b", "5b", "7bb"] },
        { ChordType.HalfDiminished7, ["1", "3b", "5b", "7b"] }
    };
}