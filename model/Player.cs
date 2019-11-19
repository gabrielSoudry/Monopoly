using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model
{
    public class Player
    {
        private string name;
        private bool isDefault = false;
        private int money;
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

        public void move()
        {
            this.landPosition += die.Roll();
            if (this.landPosition>39)
            {
                this.landPosition %= 39;
            }
        }

    }
}

