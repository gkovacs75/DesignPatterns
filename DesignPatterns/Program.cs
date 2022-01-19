using Patterns.Composite;
using Patterns.Decorator;
using Patterns.Strategy;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Decorator Pattern

            //Console.WriteLine("Decorator Pattern:");

            //IPizza pizza = new Pizza();

            //Console.WriteLine(pizza.GetPizzaType());

            //IPizza cheeseDecorator = new CheeseDecorator(pizza);
            //IPizza onionDecorator = new OnionDecorator(cheeseDecorator);
            //IPizza tomatoDecorator = new TomatoDecorator(onionDecorator);

            //Console.WriteLine(tomatoDecorator.GetPizzaType());

            #endregion

            #region Decorator Pattern

            //Console.WriteLine("Strategy Pattern:");

            //TextEditor textEditor = new TextEditor(new SpellCheckerVarientA());
            //string result = textEditor.CheckSpelling();
            //Console.WriteLine(result);

            //textEditor = new TextEditor(new SpellCheckerVarientB());
            //result = textEditor.CheckSpelling();
            //Console.WriteLine(result);

            #endregion

            #region Composite Pattern

            #region Composite Pattern

            Console.WriteLine("Composite Pattern:");

            Leaf leaf1 = new Leaf("leaf_1"); 
            Leaf leaf2 = new Leaf("leaf_2");

            Composite.Composite composite1 = new Patterns.Composite.Composite("composite_1");
            Composite.Composite composite2 = new Patterns.Composite.Composite("composite_2");

            composite1.components.Add(composite2);
            composite1.components.Add(leaf1);

            composite2.components.Add(leaf2);

            composite1.Operation();

 #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
