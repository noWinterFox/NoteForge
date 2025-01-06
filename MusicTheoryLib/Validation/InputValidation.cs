using MusicTheoryLib.Enums;
using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Validation;

public class InputValidation
{
    public static bool IsValidCommand(string input)
    {
        if (input.Substring(0, 1) != "/")
        {
            return false;
        }

        input = input.Remove(0, 1);
        
        if (!Enum.GetNames(typeof(Command)).Any(name => string.Equals(name, input, StringComparison.OrdinalIgnoreCase)))
        {
            return false;
        }
        
        return true;
    }
}