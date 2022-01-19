using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    public class SpellCheckerVarientA : ISpellCheck
    {
        public string CheckSpelling()
        {
            return "Checking Spelling Using Spell-Check Varient A";
        }
    }
}
