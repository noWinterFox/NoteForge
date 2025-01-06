using MusicTheoryLib.Data;
using MusicTheoryLib.Enums.Theory;

namespace MusicTheoryLib.Core;

public class ChordGenerator
{
    public static List<Note> GenerateChord(Note root, ChordType chordType)
    {
        List<Note> chordNotes = [];
        
        chordNotes.Clear();
        
        // Chord generation
        foreach (var note in Intervals.ChordIntervals[chordType])
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
            int noteIndex = Array.IndexOf(Enum.GetValues(typeof(Note)), ScaleGenerator.KeyScales[root][notePosition - 1]);
            
            chordNotes.Add((Note)Enum.GetValues(typeof(Note)).GetValue((noteIndex + modifier) % Enum.GetValues(typeof(Note)).Length)!);
        }
    
        return chordNotes;
    }
}