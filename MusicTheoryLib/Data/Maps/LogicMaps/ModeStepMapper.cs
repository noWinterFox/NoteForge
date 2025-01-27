using MusicTheoryLib.Data.Enums;

namespace MusicTheoryLib.Data.Maps.LogicMaps;

public class ModeStepMapper
{
    public static readonly Dictionary<Mode, int[]> ModeStepMap = new()
    {
        { Mode.Lydian, [1,1,1,2,1,1,2] },
        { Mode.IonianMajor, [1,1,2,1,1,1,2] },
        { Mode.Mixolydian, [1,1,2,1,1,2,1] },
        { Mode.Dorian, [1,2,1,1,1,2,1] },
        { Mode.AeolianMinor, [1,2,1,1,2,1,1] },
        { Mode.Phrygian, [2,1,1,2,1,1,1] },
        { Mode.Locrian, [2,1,1,1,2,1,1] }
    };
}