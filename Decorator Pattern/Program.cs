using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza p1 = new veggiPizza  ();
            Console.WriteLine(p1.getDescription());

            IPizza p2 = new CheeseDecorator(new veggiPizza ());
            Console.WriteLine(p2.getDescription());

            IPizza p3 = new OliveDecorator(new chickenPizza());
            Console.WriteLine(p3.getDescription());
        }

    }

    //base interface
    public interface IPizza
    {
        string getDescription();
    }

    //concrete implementation

    public class veggiPizza : IPizza
    {
        public string getDescription()
        {
            return "Veggi Pizza";
        }
    }

    public class chickenPizza : IPizza
    {
        public string getDescription()
        {
            return "Chicken Pizza";
        }
    }

    //base decorator

    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string getDescription()
        {
           return pizza.getDescription();
        }
    }

    //concrete decorators

    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string getDescription()
        {
            return pizza.getDescription() + " with cheese";
        }
 
    }

    public class OliveDecorator : PizzaDecorator
    {
        public OliveDecorator(IPizza pizza) : base(pizza) { }

        public override string getDescription()
        {
            return pizza.getDescription() + " with olive";
        }
    }
}
