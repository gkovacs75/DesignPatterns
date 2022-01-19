using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();

            type += "\r\n With Onion";

            return type;
        }
    }
}
