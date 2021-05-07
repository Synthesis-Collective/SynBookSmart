using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noggog;
using Mutagen.Bethesda.Synthesis.Settings;

namespace BookSmart
{
    class Settings
    {
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
        public EncapsulatingCharacters encapsulatingCharacters { get; set; } = EncapsulatingCharacters.Chevrons;

    }
}
