using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Parsers;

public class ModeParser
{
    public static Mode ParseMode(string mode)
    {
        if (Enum.TryParse(mode, true, out Mode parsedMode) && Enum.IsDefined(typeof(Mode), parsedMode))
        {
            return parsedMode;
        }

        throw new ArgumentException($"\"{mode}\" is not a valid mode");
    }
}