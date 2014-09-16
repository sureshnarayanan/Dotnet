using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class GenerateSecureTimeToken
    {
        public void GenerateToken()
        {
            int tokenExpirationtime = 5; //in minutes
            //Generate the token for given time using random guid
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());
            Console.WriteLine("This will be the token that should be passed in URL: " + token);
           

            byte[] data = Convert.FromBase64String(token);
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            if (when < DateTime.UtcNow.AddMinutes(-tokenExpirationtime))
            {
                Console.WriteLine("Token Expired.");
            }
            else
            {
                Console.WriteLine("Valid token within time limit.");                
            }

            Console.Read();
        }
    }
}
