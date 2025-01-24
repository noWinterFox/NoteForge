# File Structure for NoteForge

This document outlines the solution structure for **NoteForge** across its three phases of development. Each phase builds on the previous one, adding new libraries and applications while maintaining a modular and organized codebase.

---

## **Phase 1: Console Application**

### Solution Structure

NoteForge/

    MusicTheoryLib/ # Core music theory logic

    ConsoleApp/ # Console application

    UtilitiesLib/ # Shared utilities

    TestingLib/ # Unit and integration tests

    NoteForge.sln # Solution file


### Explanation of Libraries and Code

#### **MusicTheoryLib**
- **Purpose:** Handles all music theory logic.
- **Key Files:**
  - `ScaleGenerator.cs`: Generates scales based on root note and scale type.
  - `ChordGenerator.cs`: Generates diatonic and extended chords.
  - `IntervalCalculator.cs`: Calculates intervals between notes.
  - `NoteHelper.cs`: Handles enharmonic equivalents and note normalization.
  - `TranspositionTool.cs`: Transposes notes, scales, or chords to a new key.

#### **ConsoleApp**
- **Purpose:** A command-line interface for testing and using core features.
- **Key Files:**
  - `Program.cs`: Entry point for the console app.
  - `CommandParser.cs`: Parses user input and calls the appropriate methods from `MusicTheoryLib`.
  - `ConsoleUI.cs`: Handles console output (e.g., displaying scales, chords, intervals).

#### **UtilitiesLib**
- **Purpose:** General-purpose utilities.
- **Key Files:**
  - `Logger.cs`: Logs errors, warnings, and debug information.
  - `SettingsManager.cs`: Manages user settings (e.g., default tuning, theme preferences).
  - `FileHelper.cs`: Handles file I/O operations (e.g., loading/saving tablature, MIDI files).

#### **TestingLib**
- **Purpose:** Unit and integration tests for core libraries.
- **Key Files:**
  - `ScaleGeneratorTests.cs`: Tests for `ScaleGenerator`.
  - `ChordGeneratorTests.cs`: Tests for `ChordGenerator`.
  - `IntervalCalculatorTests.cs`: Tests for `IntervalCalculator`.

### Example Structure for Phase 1

NoteForge/

    MusicTheoryLib/

        ScaleGenerator.cs

        ChordGenerator.cs

        IntervalCalculator.cs

        NoteHelper.cs

        TranspositionTool.cs

    ConsoleApp/

        Program.cs

        CommandParser.cs

        ConsoleUI.cs

    UtilitiesLib/

        Logger.cs

        SettingsManager.cs

        FileHelper.cs

    TestingLib/

        ScaleGeneratorTests.cs

        ChordGeneratorTests.cs

        IntervalCalculatorTests.cs

    NoteForge.sln


---

## **Phase 2: WPF Application**

### Solution Structure

NoteForge/

    MusicTheoryLib/ # Core music theory logic

    MusicNotationLib/ # Sheet music and tablature logic

    AudioLib/ # Audio playback and MIDI integration

    WPFApp/ # WPF desktop application

    UtilitiesLib/ # Shared utilities

    TestingLib/ # Unit and integration tests

    NoteForge.sln # Solution file


### Explanation of Libraries and Code

#### **MusicNotationLib**
- **Purpose:** Handles sheet music and tablature-related logic.
- **Key Files:**
  - `SheetMusicGenerator.cs`: Converts notes/chords into staff notation.
  - `TablatureParser.cs`: Parses guitar tablature into notes.
  - `RhythmDetector.cs`: Infers rhythms from tablature or MIDI data.
  - `ChordSymbolGenerator.cs`: Generates chord symbols (e.g., Cmaj7, G#dim) from notes.

#### **AudioLib**
- **Purpose:** Handles audio playback and MIDI integration.
- **Key Files:**
  - `AudioPlayer.cs`: Playback scales, chords, or melodies using NAudio.
  - `MidiImporter.cs`: Imports and analyzes MIDI files.
  - `MidiExporter.cs`: Exports scales, chords, or melodies as MIDI files.

#### **WPFApp**
- **Purpose:** A desktop application with a graphical user interface.
- **Key Files:**
  - **Views:**
    - `ScaleGeneratorView.xaml`: UI for generating and displaying scales.
    - `ChordFinderView.xaml`: UI for finding and displaying chords.
    - `TablatureTranslatorView.xaml`: UI for translating tablature to sheet music.
  - **ViewModels:**
    - `ScaleGeneratorViewModel.cs`: Interacts with `MusicTheoryLib` and updates the `ScaleGeneratorView`.
    - `ChordFinderViewModel.cs`: Interacts with `MusicTheoryLib` and updates the `ChordFinderView`.
  - **Services:**
    - `AudioPlaybackService.cs`: Handles audio playback using `AudioLib`.
    - `FileExportService.cs`: Handles exporting results (e.g., PDF, MIDI).

### Example Structure for Phase 2

NoteForge/

    MusicTheoryLib/

        ScaleGenerator.cs

        ChordGenerator.cs

        IntervalCalculator.cs

        NoteHelper.cs

        TranspositionTool.cs

    MusicNotationLib/

        SheetMusicGenerator.cs

        TablatureParser.cs

        RhythmDetector.cs

        ChordSymbolGenerator.cs

    AudioLib/

        AudioPlayer.cs

        MidiImporter.cs

        MidiExporter.cs

    WPFApp/

        Views/

            ScaleGeneratorView.xaml

            ChordFinderView.xaml

            TablatureTranslatorView.xaml

        ViewModels/

            ScaleGeneratorViewModel.cs

            ChordFinderViewModel.cs

            TablatureTranslatorViewModel.cs

        Services/

            AudioPlaybackService.cs

            FileExportService.cs

        App.xaml

    UtilitiesLib/

        Logger.cs

        SettingsManager.cs

        FileHelper.cs

    TestingLib/

        ScaleGeneratorTests.cs

        ChordGeneratorTests.cs

        IntervalCalculatorTests.cs

    NoteForge.sln


---

## **Phase 3: Full DAW Integration**

### Solution Structure

NoteForge/

    MusicTheoryLib/ # Core music theory logic

    MusicNotationLib/ # Sheet music and tablature logic

    AudioLib/ # Audio playback and MIDI integration

    DAWIntegration/ # DAW plugin integration

        PluginCore/ # Shared plugin logic

        AbletonPlugin/ # Ableton Live plugin

        FLStudioPlugin/ # FL Studio plugin

        LogicProPlugin/ # Logic Pro plugin

    WPFApp/ # WPF desktop application

    UtilitiesLib/ # Shared utilities

    TestingLib/ # Unit and integration tests

    NoteForge.sln # Solution file


### Explanation of Libraries and Code

#### **DAWIntegration**
- **Purpose:** Integrates NoteForge with DAWs as a plugin.
- **Key Files:**
    - **PluginCore:**
        - `MidiProcessor.cs`: Shared logic for MIDI processing.
        - `ChordDetector.cs`: Shared logic for chord detection.
  - **DAWSpecificPlugins:**
    - `AbletonPlugin.cs`: Plugin for Ableton Live.
    - `FLStudioPlugin.cs`: Plugin for FL Studio.
    - `LogicProPlugin.cs`: Plugin for Logic Pro.

### Example Structure for Phase 3

NoteForge/

    MusicTheoryLib/

        ScaleGenerator.cs

        ChordGenerator.cs

        IntervalCalculator.cs

        NoteHelper.cs

        TranspositionTool.cs

    MusicNotationLib/

        SheetMusicGenerator.cs

        TablatureParser.cs

        RhythmDetector.cs

        ChordSymbolGenerator.cs

    AudioLib/

        AudioPlayer.cs

        MidiImporter.cs

        MidiExporter.cs

    DAWIntegration/

        PluginCore/

            MidiProcessor.cs

            ChordDetector.cs

        AbletonPlugin/

            AbletonPlugin.cs

        FLStudioPlugin/

            FLStudioPlugin.cs

        LogicProPlugin/

            LogicProPlugin.cs

    WPFApp/

        Views/

            ScaleGeneratorView.xaml

            ChordFinderView.xaml

            TablatureTranslatorView.xaml

        ViewModels/

            ScaleGeneratorViewModel.cs

            ChordFinderViewModel.cs

            TablatureTranslatorViewModel.cs

        Services/

            AudioPlaybackService.cs

            FileExportService.cs

        App.xaml

    UtilitiesLib/

        Logger.cs

        SettingsManager.cs

        FileHelper.cs

    TestingLib/

        ScaleGeneratorTests.cs

        ChordGeneratorTests.cs

        IntervalCalculatorTests.cs

    NoteForge.sln


---

## **Universal Knowledge on Structuring, Organizing, Maintaining, and Expanding Code**

### **1. Separation of Concerns**
- Keep UI, business logic, and data access in separate layers.
- Use libraries like `MusicTheoryLib` to encapsulate core logic.

### **2. Modularity**
- Build small, reusable libraries (e.g., `MusicNotationLib`, `AudioLib`).
- Avoid tightly coupling libraries to specific applications.

### **3. Testing**
- Write unit tests for all core libraries.
- Use integration tests to verify interactions between libraries.

### **4. Version Control**
- Use Git for version control.
- Create separate branches for each phase (e.g., `phase1-console`, `phase2-wpf`).

### **5. Documentation**
- Document the purpose and usage of each library.
- Use XML comments in C# to generate API documentation.

### **6. Maintainability**
- Follow consistent naming conventions and coding standards.
- Refactor code regularly to improve readability and reduce technical debt.

### **7. Scalability**
- Design libraries and applications to be easily extendable.
- Use interfaces and dependency injection to decouple components.

### **8. Collaboration**
- Use pull requests and code reviews to ensure code quality.
- Document workflows and processes for onboarding new team members.