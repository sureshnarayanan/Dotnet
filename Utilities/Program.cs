using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate time based token
           new GenerateSecureTimeToken().GenerateToken();
           
        }
    }
}
