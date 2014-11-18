using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
   
    class AccessModifiers
    {
        public void Execute()
        {
            //Read only 
            //The readonly keyword is a modifier that you can be used on fields. When a field declaration includes a readonly modifier, 
            //assignments to the fields introduced by the declaration can only occur as part of the declaration or in a constructor in the same class.
            //The readonly keyword is different from the const keyword. A const field can only be initialized at the declaration of the field. A readonly field can be 
            //initialized either at the declaration or in a constructor. Therefore, readonly fields can have different values depending on the constructor used. 
            //Also, while a const field is a compile-time constant, the readonly field can be used for runtime constants
            ReadOnlyTest p1 = new ReadOnlyTest(11, 21, 32);   // OK
            Console.WriteLine("p1: x={0}, y={1}, z={2}", p1.x, p1.y, p1.z);
            ReadOnlyTest p2 = new ReadOnlyTest();
            p2.x = 55;   // OK
           // p2.y = 10; //Not OK
            Console.WriteLine("p2: x={0}, y={1}, z={2}", p2.x, p2.y, p2.z);
            /*
        Output:
           p1: x=11, y=21, z=32
           p2: x=55, y=25, z=24
       */
        }

        public class ReadOnlyTest
        {
            public int x;
            // Initialize a readonly field 
            public readonly int y = 25;
            public readonly int z;

            public ReadOnlyTest()
            {
                // Initialize a readonly instance field
                z = 24;
            }

            public ReadOnlyTest(int p1, int p2, int p3)
            {
                x = p1;
                y = p2;
                z = p3;
            }
        }    

    }
}
