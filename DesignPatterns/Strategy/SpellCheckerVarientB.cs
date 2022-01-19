using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    public class SpellCheckerVarientB : ISpellCheck
    {
        public string CheckSpelling()
        {
            return "Checking Spelling Using Spell-Check Varient B";
        }
    }
}
