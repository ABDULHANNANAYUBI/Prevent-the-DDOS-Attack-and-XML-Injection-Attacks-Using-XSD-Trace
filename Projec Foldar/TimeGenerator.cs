using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finite_Automata
{
    public class TimeGenerator
    {
        static readonly Random rnd = new Random();

        public static DateTime RandomDay()
        {
            DateTime from = new DateTime(2018, 1, 1);
            DateTime to = DateTime.Now;

            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(rnd.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }
    }
}
