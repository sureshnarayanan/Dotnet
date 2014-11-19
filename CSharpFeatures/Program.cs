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
            new Generics().Execute();
            Console.WriteLine("<-----Generics End------->");

            //Delegates
            Console.WriteLine("<-----Delegates Start------->");
            new DelegatesAndAnonymousFunctions().Execute();           
            Console.WriteLine("<-----Delegates End------->");

            //Nullable types
            Console.WriteLine("<-----NullableTypes Start------->");
            new NullableAndAnonymousTypes().Execute();
            Console.WriteLine("<-----NullableTypes End------->");

            //Lamda expression
            Console.WriteLine("<-----Lambda Start------->");
            new LambdaExpression().Execute();
            Console.WriteLine("<-----Lambda End------->");

            //Extension Methods 
            Console.WriteLine("<-----ExtensionMethods Start------->");
            new ExtensionMethods().Execute();
            Console.WriteLine("<-----ExtensionMethods End------->");

            //Entity framework Methods 
            Console.WriteLine("<-----EntityFramework Start------->");
            new EntityFrameworkClass().Execute();
            Console.WriteLine("<-----EntityFramework End------->");


            Console.WriteLine("Done. Press any key to exit");

            Console.ReadLine();
        }
    }
}
