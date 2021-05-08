# SynBookSmart
Enhance book titles to show more information about them. Fully configurable.

## Settings
All settings can be configured inside the Synthesis app.

### Add Skill Labels
Adds a label to any books you find that will cause you to gain skills. Dynamically pulls this information from any book as long as it has the standard 'Teaches Skill' script attached. Will not work if a custom mod is using different scripts to apply the skill up.

### Add Map Marker Labels
Adds a label to any books you find that will give you a map marker via script. Will work as long as the script is on the book itself and contains "MapMarker" (case insensitive) somehwere in the script name. Will not apply to scripts belonging to the quest record instead of the book. This may be able to be improved in the future.

#### Add Quest Labels
Adds a label to any books you find that are involved in a quest. Enabling this label will require the patcher to create a quest book cache at the beginning of each run, which will extend processing time a bit. This cache looks through all quests and finds any aliases that reference a book. If found, that book will be marked as a quest book. Also checks for scripts on the book itself that have the word "Quest" (case insenstive) in the name. Please open a [Github issue](https://github.com/Synthesis-Collective/SynBookSmart/issues) if you find a quest book that is not being caught by the patcher, even if it's from a mod.

### Label Position
- Before_Name
  - `<Alchemy> Snape's Book of Potions`
- After_Name
  - `Snape's Book of Potions <Alchemy>`

### Label Format
- Star
  - `*Snape's Book of Potions`
- Short
  - `<Alch> Snape's Book of Potions`
- Long
  - `<Alchemy> Snape's Book of Potions`

### Encapsulating Characters
This setting has no effect if a Label Format of `Star` is chosen.

- Parenthesis
  - `(Alch) Snape's Book of Potions`
- Curly Brackets
  - `{Alch} Snape's Book of Potions`
- Square Brackets
  - `[Alch] Snape's Book of Potions`
- Chevrons
  - `<Alch> Snape's Book of Potions`
- Stars
  - `*Alch* Snape's Book of Potions`
