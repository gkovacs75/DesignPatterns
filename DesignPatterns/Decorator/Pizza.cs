using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "Plain Pizza";
        }
    }
}
