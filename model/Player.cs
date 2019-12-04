using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Monopoly_TD7.model.RollingDie;

namespace Monopoly_TD7.model
{
    public class Player
    {
        private static RollingDie die;

        public int LandPosition { get; set; }
        public int NumberOfDouble { get; set; }
        public bool Release { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; }
        public double Money { get; set; }
        public bool IsOnJail { get; set; }
        public int CountTurnJail { get; set; }
       
        public Player(string name)
        {
            Name = name;
            IsDefault = false;
            Money = 3000;
            LandPosition = 0;
            die = new RollingDie();
        }

        public randomDie move()
        {
            randomDie result = die.Roll();

            if (!this.IsOnJail)
            {
                this.LandPosition += (result.die1 + result.die2);
            }
            else
            {
                // The players leave the jail ! 
                if (result.die1 == result.die2 || CountTurnJail == 3)
                {
                    this.IsOnJail = false;
                    this.LandPosition += (result.die1 + result.die2);
                    CountTurnJail = 0;
                    this.Release = true;
                }
                else
                {
                    CountTurnJail++;
                }
            }

            if (this.LandPosition>39)
            {
                this.LandPosition %= 39;
            }
            if(this.LandPosition==30)
            {
                this.IsOnJail = true;
                this.LandPosition = 10;
            }
            return result;
        }

    }
}

