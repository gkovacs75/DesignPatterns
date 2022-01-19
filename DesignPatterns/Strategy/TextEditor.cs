using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    public class TextEditor
    {
        ISpellCheck spellChecker;

        public TextEditor(ISpellCheck spellChecker)
        {
            this.spellChecker = spellChecker;
        }

        public string CheckSpelling()
        {
            return this.spellChecker.CheckSpelling();
        }
    }
}
