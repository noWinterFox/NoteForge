namespace MusicAssistant;

class Program
{
    static void Main(string[] args)
    {
        var initializeDictionary = Scale.KeyScales; // initializes the KeyScales dictionary, just ignore this

        Chord chord = new Chord("bMajorTriad");

        Console.Write($"{chord.Name}: ");

        foreach (var note in chord.ChordNotes)
        {
            Console.Write($"{note} ");
        }

        Console.WriteLine();

    }
}
