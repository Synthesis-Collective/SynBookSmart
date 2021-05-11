using Mutagen.Bethesda.Synthesis.Settings;

namespace BookSmart
{
    class Settings
    {
        // Which labels to add
        [SynthesisOrder]
        [SynthesisTooltip("Add a skill tag to the book name if the book teaches a skill.")]
        public bool addSkillLabels = true;
        
        [SynthesisOrder]
        [SynthesisTooltip("Add a map marker tag to the book name if the book teaches map markers.")]
        public bool addMapMarkerLabels = true;

        [SynthesisOrder]
        [SynthesisTooltip("Add a quest tag to the book name if the book is used in a quest.")]
        public bool addQuestLabels = true;

        [SynthesisOrder]
        [SynthesisTooltip("Assumes that any BOOK with a script on it is a quest book. May incorrectly mark some books. Will improve detection for mod books that use their own scripts.")]
        public bool assumeBookScriptsAreQuests = false;

        // Label Position
        public enum LabelPosition
        {
            Before_Name,
            After_Name
        }

        [SynthesisOrder]
        [SynthesisSettingName("Label Position")]
        [SynthesisTooltip("Where to put the label when creating the new name.")]
        public LabelPosition labelPosition { get; set; } = LabelPosition.Before_Name;

        // Label Format
        public enum LabelFormat
        {
            Star,
            Short,
            Long
        }

        [SynthesisOrder]
        [SynthesisSettingName("Label Format")]
        [SynthesisTooltip("Star: *BookName\r\nShort: <Alch> BookName\r\nLong: <Alchemy> BookName")]
        public LabelFormat labelFormat { get; set; } = LabelFormat.Long;

        // Encapsulating Characters
        public enum EncapsulatingCharacters
        {
            Parenthesis,
            Curly_Brackets,
            Square_Brackets,
            Chevrons,
            Stars           
        }

        [SynthesisOrder]
        [SynthesisSettingName("Encapsulating Characters")]
        [SynthesisTooltip("The characters to wrap the skill name in.\r\nParenthesis: ()\r\nCurly Brackets: {}\r\nSquare Brackets: []\r\nChevrons: <>\r\nStars: *")]
        public EncapsulatingCharacters encapsulatingCharacters { get; set; } = EncapsulatingCharacters.Parenthesis;
    }
}
