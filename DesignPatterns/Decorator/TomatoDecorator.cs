using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();

            type += "\r\n With Tomato";

            return type;
        }
    }
}
