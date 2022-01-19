using System;
using System.Collections.Generic;

namespace Patterns.Composite
{
    public class Composite : IComponent
    {
        private string name;
        public List<IComponent> components = new List<IComponent>();

        public Composite(string name)
        {
            this.name = name;
        }

        public void Operation()
        {
            Console.WriteLine(this.name);

            foreach (IComponent component in components)
            {
                component.Operation();
            }
        }
    }
}
