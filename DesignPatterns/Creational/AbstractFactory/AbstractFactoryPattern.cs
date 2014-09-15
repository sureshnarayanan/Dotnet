using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //The abstract factory pattern provides a way to encapsulate a group of individual factories(eg:companies) that have a common theme(eg:products) without specifying their concrete classes(what products or what companies).
    //In normal usage, the client software creates a concrete implementation of the abstract factory and then uses the generic interface of the factory to create the concrete objects that are part of the theme.
    //The client doesn't know (or care) which concrete objects it gets from each of these internal factories, since it uses only the generic interfaces of their products.[
    //This pattern separates the details of implementation of a set of objects from their general usage and relies on object composition, 
    //as object creation is implemented in methods exposed in the factory interface
    //Use of this pattern makes it possible to interchange concrete implementations without changing the code that uses them, even at runtime. 
    //However, employment of this pattern, as with similar design patterns, may result in unnecessary complexity and extra work in the initial writing of code. 
    //Additionally, higher levels of separation and abstraction can result in systems which are more difficult to debug and maintain. 
    //Therefore, as in all software designs, the trade-offs must be carefully evaluated
    class AbstractFactoryPattern
    {        
        public void ExecutePattern()
        {
            Factory microsoft = new PCFactory();
            Product msProduct = microsoft.Produce();
            Console.WriteLine(msProduct.GetProduct());

            Factory apple = new MacFactory();
            Product appleProduct = apple.Produce();
            Console.WriteLine(appleProduct.GetProduct());
        }



        abstract class Factory//AbstractFactory
        {
            public abstract Product Produce();
        }

        abstract class Product //AbstractProduct
        {
            public abstract string GetProduct();
        }

        class PCFactory : Factory
        {
            public override Product Produce()
            {
                return new PCProduct();
            }
        }

        class MacFactory : Factory
        {
            public override Product Produce()
            {
                return new MacProduct();
            }
        }

        class PCProduct : Product
        {
            public override string GetProduct()
            {
                return "PCProduct";
            }
        }

        class MacProduct : Product
        {
            public override string GetProduct()
            {
                return "MacProduct";
            }
        }

    }
}
