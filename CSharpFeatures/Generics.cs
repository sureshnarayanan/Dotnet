using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    //Generics introduce to the .NET Framework the concept of type parameters, which make it possible to design classes and methods that defer the specification of 
    //one or more types until the class or method is declared and instantiated by client code. 
    //Generics allow you to define type-safe data structures, without committing to actual data types. This results in a significant performance boost and higher quality code, 
    //because you get to reuse data processing algorithms without duplicating type-specific code
    class Generics
    {
        public void Execute()
        {
            GenericStack<string> s = new GenericStack<string>();
            s.Push("1");
            s.Push("4");
            s.Push("6");

            s.Pop();
           
            s.DisplayList();
        }        
    }

    public class Stack
    {
        List<int> list = new List<int>();
        public void Push(int i)
        {
            list.Add(i);
        }

        public void Pop()
        {
            list.RemoveAt(list.Count-1);
        }

        public void DisplayList()
        {
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }


    public class GenericStack<T>
    {
        List<T> list = new List<T>();
        public void Push(T i)
        {
            list.Add(i);
        }

        public void Pop()
        {
            list.RemoveAt(list.Count-1);
        }

        public void DisplayList()
        {
            foreach (T i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
