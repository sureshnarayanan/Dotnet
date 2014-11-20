using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CSharpFeatures
{
    //A lambda expression is an anonymous function that you can use to create delegates or expression tree types. By using lambda expressions, 
    //you can write local functions that can be passed as arguments or returned as the value of function calls. 
    //Lambda expressions are particularly helpful for writing LINQ query expressions
    class LambdaExpression
    {
        public delegate void DelegateMethod1(string s);
        public delegate int DelegateMethod2(int i);
        public delegate bool DelegateMethod3(int i, string s, bool b);

        public void Execute()
        {
            //Lambda Expressions 
            DelegateMethod1 handler = x => { Console.WriteLine("Lambda:" + x); };
            handler("test");

            DelegateMethod2 handler2 = x => x * x;
            Console.WriteLine(handler2(5)); 

            //Expression tree
            //Expression trees represent code in a tree-like data structure, where each node is an expression, for example, a method call or a binary operation such as x < y.
            Expression<DelegateMethod2> expTree = x => x * x;
            Console.WriteLine(expTree);

            //Execute exp tree
            DelegateMethod2 handler3 = expTree.Compile();
            Console.WriteLine(handler3(5));

            //Multiple params
            DelegateMethod3 handler4 = (x, y, z) => (y.Length == x) == z;
            Console.WriteLine(handler4(4, "test", true));

            //Expression<Func>
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0,11 };
            Console.WriteLine(numbers.Count(n => n % 2 == 1));
            //returns list
            var v = numbers.TakeWhile(n => n < 6);

            //Func<T> is a predefined system delegate type 
            Func<int, int, string> func = (x, y) => (x * y).ToString();
            Console.WriteLine(func(5,6));
        }
    }
}
