using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactory
            Console.WriteLine("<----------Abstract Factory Pattern Start------>\n");
            new AbstractFactoryPattern().ExecutePattern();
            Console.WriteLine("\n<----------Abstract Factory Pattern End------>\n");

            //AdapterPattern
            Console.WriteLine("<----------Adapter Pattern Start------>\n");
            new AdapterPattern().ExecutePattern();
            Console.WriteLine("\n<----------Adapter Pattern End------>\n");

            //BridgePattern
            Console.WriteLine("<----------Bridge Pattern Start------>\n");
            new BridgePattern().ExecutePattern();
            Console.WriteLine("\n<----------Bridge Pattern End------>\n");

            //CompositePattern
            Console.WriteLine("<----------Composite Pattern Start------>\n");
            new CompositePattern().ExecutePattern();
            Console.WriteLine("\n<----------Composite Pattern End------>\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
