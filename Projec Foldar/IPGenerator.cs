using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Finite_Automata
{
    public class IPGenerator
    {
        public string GenerateIP()
        {

            var data = new byte[4];
            new Random().NextBytes(data);
            IPAddress ip = new IPAddress(data);

            return ip.ToString();

        }
    }
}
