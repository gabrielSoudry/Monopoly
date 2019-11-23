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
        private string name;
        private bool isDefault = false;
        private double money;
        private int landPosition;
        private bool isOnJail = false;
        private int countTurnJail;
        private int numberOfdouble = 0;

        private static RollingDie die;

        public Player(string Name)
        {
            name = Name;
            isDefault = false;
            money = 3000;
            landPosition = 0;
            die = new RollingDie();
        }

        public int LandPosition
        {
            get
            {
                return landPosition;
            }
            set
            {
                landPosition = value;
            }
        }

        public int NumberOfDouble { get; set; }

        public bool Release { get; set; }

        public string Name
        {

            get
            {
                return name;
            }
        }

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money=value;
            }
        }

        public bool IsOnJail
        {
            get
            {
                return isOnJail;
            }
            set
            {
                isOnJail = value;
            }
        }

        public randomDie move()
        {
            randomDie result = die.Roll();

            if (!this.isOnJail)
                this.landPosition += (result.die1+ result.die2);
            else
            {
                // The players leave the jail ! 
                if (result.die1 == result.die2 || countTurnJail==3) 
                {
                    this.isOnJail = false;
                    this.landPosition += (result.die1 + result.die2);
                    countTurnJail = 0;
                    this.Release = true;
                }
                else
                {
                    countTurnJail++;
                }
            }

            if (this.landPosition>39)
            {
                this.landPosition %= 39;
            }
            if(this.landPosition==30)
            {
                this.isOnJail = true;
                this.landPosition = 10;
            }

            return result;
        }

    }
}

