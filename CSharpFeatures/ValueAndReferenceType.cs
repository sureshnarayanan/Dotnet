using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class ValueAndReferenceType
    {
        public void Execute()
        {
            //A reference type is a type which has its value, a reference to the appropriate data, rather than the data itself. 
            StringBuilder r1 = new StringBuilder();
            r1.Append("hello");
            StringBuilder r2 = r1;
            Console.WriteLine(r2); // Prints hello


            StringBuilder r11 = new StringBuilder();
            r11.Append("hello");
            StringBuilder r22 = r11;
            r11.Append(" world");
            Console.WriteLine(r22); // Prints hello world


            StringBuilder r111 = new StringBuilder();
            r111.Append("hello");
            StringBuilder r222 = r111;
            r111.Append(" world");
            r111 = new StringBuilder("goodbye"); //New reference created
            Console.WriteLine(r111); // Prints goodbye
            Console.WriteLine(r222); // Still prints hello world

            //Parameter Passing of reference value
            StringBuilder s = new StringBuilder();
            s.Append("hello");
            Change1(s);
            Console.WriteLine(s == null);//False

            StringBuilder s1 = new StringBuilder();
            s1.Append("hello");
            Change2(s1);
            Console.WriteLine(s1);//Hello world

            List<string> ls = new List<string>();
            ls.Add("hello");
            ChangeList1(ls);
            foreach(string lss in ls)Console.WriteLine(lss);//hello

            List<string> ls1 = new List<string>();
            ls1.Add("hello");
            ChangeList2(ls1);
            foreach (string lss in ls1) Console.WriteLine(lss);//hello world

            //While reference types have a layer of indirection between the variable and the real data, value types don't. 
            //Variables of a value type directly contain the data. Assignment of a value type involves the actual data being copied
            IntHolder v1 = new IntHolder();
            v1.i = 5;
            IntHolder v2 = v1;
            v1.i = 6;
            Console.WriteLine(v2.i);
        }

        void Change1(StringBuilder x)
        {
            x = null;//Setting the reference and not the actual value to null
        }

        void Change2(StringBuilder x)
        {
            x.Append("world");
        }

        void ChangeList1(List<string> x)
        {
            x = null;//Setting the reference and not the actual value to null
        }

        void ChangeList2(List<string> x)
        {
            x.Add("world");
        }

        public struct IntHolder
        {
            public int i;
        }
    }
}
