using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics
            Console.WriteLine("<-----Generics Start------->");
            Generics g = new Generics();
            g.Execute();
            Console.WriteLine("<-----Generics End------->");

            //Delegates
            Console.WriteLine("<-----Delegates Start------->");
            DelegatesAndAnonymousFunctions d = new DelegatesAndAnonymousFunctions();
            d.Execute();
            Console.WriteLine("<-----Delegates End------->");

            //Nullable types
            Console.WriteLine("<-----NullableTypes Start------->");
            NullableAndAnonymousTypes n = new NullableAndAnonymousTypes();
            n.Execute();
            Console.WriteLine("<-----NullableTypes End------->");

            //Lamda expression
            Console.WriteLine("<-----Lambda Start------->");
            LambdaExpression l = new LambdaExpression();
            l.Execute();
            Console.WriteLine("<-----Lambda End------->");

            //Extension Methods 
            Console.WriteLine("<-----ExtensionMethods Start------->");
            ExtensionMethods e = new ExtensionMethods();
            e.Execute();
            Console.WriteLine("<-----ExtensionMethods End------->");

            //Entity framework Methods 
            Console.WriteLine("<-----EntityFramework Start------->");
            EntityFrameworkClass ef = new EntityFrameworkClass();
            ef.Execute();
            Console.WriteLine("<-----EntityFramework End------->");


            Console.WriteLine("Done. Press any key to exit");

            Console.ReadLine();
        }
    }
}
