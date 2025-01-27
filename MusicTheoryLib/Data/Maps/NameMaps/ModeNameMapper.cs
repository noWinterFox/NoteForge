using MusicTheoryLib.Data.Enums;

namespace MusicTheoryLib.Data.Maps.NameMaps;

public class ModeNameMapper
{
    public static readonly Dictionary<string, Mode> Map = new()
    {
        { "Ionian", Mode.IonianMajor },
        { "Major", Mode.IonianMajor },
        { "Aeolian", Mode.AeolianMinor },
        { "Minor", Mode.AeolianMinor }
    };
}