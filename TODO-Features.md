# NoteForge features

## Phase 1: Console Application

### Core Features

#### Scale Generator
- Input a root note and scale type (e.g., major, minor, harmonic minor, Dorian, etc.), and the app generates the scale instantly.
- Display the scale in text format: notes only.
- Option to show enharmonic equivalents (e.g., C# vs. Db) and toggle between different notation systems, such as Helmholtz or scientific pitch notation.

  **Advanced Options:**
  - Include historical or obscure scales (e.g., medieval modes, whole-tone scales).
  - Show how scales relate to each other (e.g., how the melodic minor scale differs from the natural minor).

#### Diatonic Chord Finder
- Input a key and scale, and the app generates all diatonic chords (triads, seventh chords, etc.).
- Display chords in text format.

  **Advanced Options:**
  - Include options for extended chords (e.g., 9ths, 11ths, 13ths) and altered chords (e.g., #5, b9).
  - Show variations of diatonic chords (e.g., minor 7 vs. dominant 7 in a major key).

#### Interval Calculator
- Input two notes, and the app calculates the interval between them.

#### Transposition Tool
- Transpose chords, scales, or melodies to a new key with one click.

  **Advanced Options:**
  - Allow users to set rules for transposition (e.g., maintain chord function vs. exact interval transposition).

---

## Phase 2: WPF Application

### Enhanced Features

#### Scale Generator
- Display scales visually: piano roll and guitar fretboard.
- Allow user interaction with the visual representations.

#### Diatonic Chord Finder
- Highlight diatonic chords in a progression.
- Show chord functions (tonic, subdominant, dominant, etc.) visually.

#### Chord Progression Analyzer
- Input a chord progression, and the app identifies the key(s), scale(s), and harmonic functions.
- Highlight common patterns (e.g., ii-V-I, circle of fifths progressions).

  **Advanced Analysis:**
  - Detect modal interchange (e.g., borrowed chords from parallel modes).
  - Identify secondary dominants and extended harmony (e.g., augmented sixth chords).

#### Circle of Fifths Visualizer
- Interactive circle of fifths to quickly see related keys, diatonic chords, and modulations.
- Highlight relative major/minor pairs and parallel keys.

  **Advanced Features:**
  - Show common modulation paths between keys using the circle of fifths.
  - Map chord functions (tonic, dominant, etc.) onto the circle of fifths.

#### Practice Tools
- Built-in metronome for practicing scales, chords, or progressions.
- Playback options for generated scales, chords, or progressions with adjustable tempo and instrument sounds.
- Loop specific sections of a progression or melody for practice or improvisation.

#### Theory Glossary
- Include a searchable glossary of music theory terms and concepts.

#### Tab-to-Sheet Music Translator
- **Input:** Guitar tablature (text-based or graphical) and tuning (e.g., standard, drop D).
- **Output:** Traditional sheet music (staff notation) with notes, rhythms, and dynamics.
- **Visual Representation:** Display notes on a piano roll and interactive guitar fretboard.
- **Playback:** Play back the translated sheet music with adjustable tempo and instrument sounds.
- **Export Options:** Export as PDF, MIDI, or MusicXML for use in other software.

  **Advanced Features:**
  - Rhythm detection to infer note durations from tablature.
  - Chord recognition to display chord symbols above the staff.
  - Support for custom tunings (e.g., open G, drop D).
  - Error correction for common tablature mistakes.

#### Dark Mode and Custom Themes
- Visual customization for better usability in different environments.

#### Advanced Harmonic Analysis
- Voice leading analysis: Analyze and suggest smooth voice leading for chord progressions.
- Highlight non-chord tones (e.g., passing tones, suspensions) in melodies.

#### Interactive Examples
- Provide interactive examples of famous songs or compositions to demonstrate theory concepts.

#### Tab-to-Sheet Music Translator (Enhanced)
- **Real-Time Translation:** Translate tablature to sheet music as the user types or uploads.
- **Interactive Learning:** Highlight the relationship between tablature and sheet music with tooltips and annotations.
- **Advanced Visualizations:** Show notes on a piano roll and fretboard simultaneously.
- **Customizable Output:** Allow users to adjust clefs, time signatures, and key signatures.

---

## Phase 3: Full DAW Integration

### Advanced Features

#### MIDI Integration
- Import MIDI files, and the app analyzes the chords, scales, and progressions.
- Export generated scales or chords as MIDI for use in a DAW.

#### Chord Voicing Generator
- Input a chord, and the app generates common voicings for piano, guitar, or other instruments.
- Show open, closed, and extended voicings (e.g., drop 2, drop 3).

#### Non-Western Scales and Modes
- Include scales from other traditions (e.g., Hirajoshi, Phrygian Dominant, Byzantine).
- Show how these scales can be used in Western harmony.

#### Melodic Analysis
- Input a melody, and the app identifies the implied harmony or suggests chords that fit.
- Highlight non-chord tones (e.g., passing tones, suspensions).

#### Custom Tunings
- Support for alternate tunings (e.g., drop D, open G) and instruments (e.g., ukulele, bass).
- Show scales and chords in the context of the custom tuning.

  **Advanced Options:**
  - Support microtonal or non-Western tuning systems (e.g., quarter tones, Just Intonation).

#### Visual Audio Tools
- Integrated waveform visualizer for MIDI or audio playback.
- Live chord detection and display as audio plays.

#### Advanced Export Options
- Export results as text, PDF, MIDI, or WAV/MP3.
- Customizable output formats (e.g., chord charts, piano roll diagrams).

  **DAW Integration:**
  - Export directly to DAW formats (e.g., Ableton Live Set, Logic Pro project) with pre-configured tracks for chords, melody, and bass.

#### Collaborative Features
- Cloud-based project saving and sharing.
- Real-time collaboration on music theory analysis.
- Commenting and annotation for shared projects.

#### DAW Plugin Support
- Integrate as a plugin for popular DAWs (e.g., Ableton Live, FL Studio, Logic Pro).

#### AI-Powered Suggestions
- Suggest chord progressions based on a given melody or mood (e.g., "happy," "dark," "jazzy").
- Generate melodies based on a chord progression or scale.
- Suggest progressions or scales that emulate specific genres or artists (e.g., "sounds like John Coltrane" or "EDM-style chords").

#### Integration with Music Streaming
- Analyze the chords and scales of songs from streaming platforms (e.g., Spotify, Apple Music).
- Generate theory-based playlists (e.g., "songs in Dorian mode" or "progressions with secondary dominants").

#### Advanced Visualization
- Harmonic spectrum analysis: Visualize the harmonic content of a chord or progression using a spectrogram or harmonic series display.
- Chord inversion maps: Show common paths for chord inversions and voice leading on a visual map.

---

## User Experience Features (Applicable Across All Phases)

### Fast and Intuitive Interface
- Minimal input required (e.g., select a key and scale type with dropdowns or sliders).
- Instant results with no lag.

### Offline Mode
- All features work without an internet connection.

### Cross-Platform Sync
- Sync data across devices (e.g., phone, tablet, desktop) and integrate cloud-based storage for user projects, enabling easy access and collaboration.

### Keyboard Shortcuts (Desktop)
- Quick shortcuts for power users to speed up workflow.

---

## Example Use Cases

### Composers
- Quickly generate scales and diatonic chords for a new piece.

### Producers
- Analyze a chord progression to find non-diatonic chords for added tension.

### Improvisers
- Find scales that fit over a specific chord or progression.

### Educators
- Demonstrate theory concepts to students without manual calculations.

### Songwriters
- Transpose a song to a new key or explore alternate chord voicings.

### Guitarists
- Translate tablature to sheet music for better understanding and communication.
- Visualize scales and chords on a fretboard for practice and improvisation.