using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model
{
   
    public class RollingDie
    {
        public struct randomDie { public int die1; public int die2; }

        public Random Random { get; }
        public int SidesCount { get; set; }
        public RollingDie() => (Random, SidesCount) = (new Random(), 6);

        public randomDie Roll()
        {
            randomDie result;
            result.die1 = Random.Next(1, SidesCount + 1);
            result.die2 = Random.Next(1, SidesCount + 1);
            return result;
        }
    }
}
