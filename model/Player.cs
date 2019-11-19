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

        private RollingDie die;

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
                value = landPosition;
            }
        }

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
                value = money;
            }
        }

        public randomDie move()
        {
            randomDie result = die.Roll();
            this.landPosition += (result.die1+ result.die2);
            if (this.landPosition>39)
            {
                this.landPosition %= 39;
            }
            return result;
        }

    }
}

