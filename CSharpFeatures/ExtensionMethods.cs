using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class ExtensionMethods
    {
        //Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. 
        //Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type.
        //The most common extension methods are the LINQ standard query operators that add query functionality to the existing System.Collections.IEnumerable and 
        //    System.Collections.Generic.IEnumerable<T> types. To use the standard query operators, first bring them into scope with a using System.Linq directive. 
        //Then any type that implements IEnumerable<T> appears to have instance methods such as GroupBy, OrderBy, Average, and so on.
        public void Execute()
        {
            string s = "test extension method";
            s.Print();
            //You can use extension methods to extend a class or interface, but not to override them. An extension method with the same name and signature as an 
            //interface or class method will never be called. At compile time, extension methods always have lower priority than instance methods defined in the 
            //type itself. In other words, if a type has a method named Process(int i), and you have an extension method with the same signature, the compiler
            //will always bind to the instance method. In general, we recommend that you implement extension methods sparingly and only when you have to. Whenever possible, 
            //client code that must extend an existing type should do so by creating a new type derived from the existing type. 
        }       
    }

    public static class ExtensionClass
    {
        public static void Print(this string s)
        {
            Console.WriteLine(s);
        }
    }
}
