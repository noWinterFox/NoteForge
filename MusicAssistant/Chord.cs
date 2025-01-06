namespace MusicAssistant;

public class Chord
{
    public readonly string Name;
    public readonly List<Note> ChordNotes;
            
    private static readonly Dictionary<ChordType, string[]> ChordIntervals = new()
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
    
    // Mapping for accidentals (sharp/flat) to standardized note names
    private static readonly Dictionary<string, string?> NoteMap = new(StringComparer.OrdinalIgnoreCase)
    {
        { "A#", "ASharpBFlat" }, { "Bb", "ASharpBFlat" },
        { "C#", "CSharpDFlat" }, { "Db", "CSharpDFlat" },
        { "D#", "DSharpEFlat" }, { "Eb", "DSharpEFlat" },
        { "F#", "FSharpGFlat" }, { "Gb", "FSharpGFlat" },
        { "G#", "GSharpAFlat" }, { "Ab", "GSharpAFlat" }
    };

    public Chord(string name)
    {
        Name = name;
        ChordNotes = GenerateChord(name);
    }
    
    private static Note ParseNote(string note)
    {
        // Check if the note exists in the NoteMap and parse accordingly
        if (NoteMap.TryGetValue(note, out string? enumName))
        {
            if (Enum.TryParse(enumName, true, out Note parsedNote) && Enum.IsDefined(typeof(Note), parsedNote))
            {
                return parsedNote;
            }
        }
        else
        {
            // Try to parse the note directly if not an accidental
            if (Enum.TryParse(note, true, out Note parsedNote) && Enum.IsDefined(typeof(Note), parsedNote))
            {
                return parsedNote;
            }
        }

        throw new ArgumentException($"\"{note}\" is not a valid note");
    }
    
    private static List<Note> GenerateChord(string input)
    {
        Note root;
        ChordType chordType;
        List<Note> chordNotes = [];
        
        string remove;
        
        // Input validation to get the root note, move to separate method later
        if (input[..2].EndsWith('#') || input[..2].EndsWith('b'))
        {
            root = ParseNote(input[..2]);
            remove = input[..2];
        }
        else
        {
            root = ParseNote(input[..1]);
            remove = input[..1];
        }
    
        input = input.Remove(0, remove.Length);
        
        // Parsing the chord type
        if (Enum.TryParse(input, true, out ChordType parsedChordType) && Enum.IsDefined(typeof(ChordType), parsedChordType))
        {
            chordType = parsedChordType;
        }
        else
        {
            throw new ArgumentException($"{input} is not a valid chord type");
        }
        
        chordNotes.Clear();
        
        // Chord generation
        foreach (var note in ChordIntervals[chordType])
        {
            int modifier = 0;
            
            // Applying accidentals
            foreach (var character in note)
            {
                if (character == 'b') modifier--;
                if (character == '#') modifier++;
            }
            
            // Extracting the note position and applying the modifier
            int notePosition = Convert.ToInt32(note[..1]);
            int noteIndex = Array.IndexOf(Enum.GetValues(typeof(Note)), Scale.KeyScales[root][notePosition - 1]);
            
            chordNotes.Add((Note)Enum.GetValues(typeof(Note)).GetValue((noteIndex + modifier) % Enum.GetValues(typeof(Note)).Length)!);
        }
    
        return chordNotes;
    }
}