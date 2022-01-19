using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorator
{
    public class PizzaDecorator : IPizza
    {
        private IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return this.pizza.GetPizzaType();
        }
    }
}
