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

        public Player(string Name)
        {
            name = Name;
            isDefault = false;
            money = 3000;
            landPosition = 0;
        }
    }
}

