using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    //A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, 
    //you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.
    //Delegates are used to pass methods as arguments to other methods. Event handlers are nothing more than methods that are invoked through delegates
    class DelegatesAndAnonymousFunctions
    {
        public delegate void DelegateMethod(string message);
        public delegate void DelegateMethodWithNoArg();

        public void DisplayMessage(string message)
        {
            Console.WriteLine("Display:" + message);
        }

        public void Alert(string message)
        {
            Console.WriteLine("Alert:" + message);
        }

        public void CallbackMethod(DelegateMethod d)
        {
            d("test callback");
        }

        public void Execute()
        {
            //Delegates
            DelegateMethod handler1 = DisplayMessage;
            handler1("test");

            DelegateMethod handler2 = Alert;
            handler2("test");

            DelegateMethod handler3 = Alert;
            CallbackMethod(handler1+handler3);

            //Anonymous method
            DelegateMethod handler4 = delegate(string s)
            {
                Console.WriteLine("Anonymous:" + s);
            };
            handler4("test");

            DelegateMethodWithNoArg handler5 = delegate()
            {
                Console.WriteLine("Anonymous:");
            };
            handler5();

            //Lambda Expressions 
            DelegateMethod handler6 = (x) => { Console.WriteLine("Lambda:" + x); };
            handler6("test");

            //Lambda Expressions without param
            DelegateMethodWithNoArg handler7 = () => { Console.WriteLine("Lambda:"); };
            handler7();

            //Func delegates are very useful for encapsulating user-defined expressions that are applied to each element in a set of source data.
            //delegate can be instantiated as Func<int,bool> myFunc where int is an input parameter and bool is the return value. The return value is always 
            //specified in the last type parameter. Func<int, string, bool> defines a delegate with two input parameters, int and string, and a return type of bool. 
            //The following Func delegate, when it is invoked, will return true or false to indicate whether the input parameter is equal to 5:
            Func<int, bool> myFunc = x => x == 5;
            Console.WriteLine(myFunc(5));


        }
    }
}
