namespace MusicAssistant;

public enum Note
{
    A,
    ASharpBFlat,
    B,
    C,
    CSharpDFlat,
    D,
    DSharpEFlat,
    E,
    F,
    FSharpGFlat,
    G,
    GSharpAFlat
}

public enum Mode
{
    Lydian,
    Ionian,
    Major,
    Mixolydian,
    Dorian,
    Aeolian,
    Minor,
    Phrygian,
    Locrian
}

public enum ChordType
{
    MajorTriad,
    MinorTriad,
    DiminishedTriad,
    
    AugmentedTriad,
    Sus2,
    Sus4,
    
    Major7,
    Minor7,
    Dominant7,
    Diminished7,
    HalfDiminished7
}