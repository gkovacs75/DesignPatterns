using System;

namespace Patterns.Composite
{
    public class Leaf : IComponent
    {
        private string name;

        public Leaf(string name)
        {
            this.name = name;
        }

        public void Operation()
        {
            Console.WriteLine(this.name);
        }
    }
}
