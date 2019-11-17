using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model
{
    class RollingDie
    {  
        public Random Random {get; }
        public int SidesCount { get; set; }
        public RollingDie() => (Random, SidesCount) = (new Random(), 6);

        public int Roll()
        {
            return Random.Next(1, SidesCount + 1)+ Random.Next(1, SidesCount + 1);
        }
    }
}
