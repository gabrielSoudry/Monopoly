using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands.StategyPattern
{
    public class PurchasableStrategy : SealableStrategy
    {
        public Player LandOwner { get; set; }
        public double Price { get; set; }

        public PurchasableStrategy(double price) =>(Price) = (price);
       
        public override bool Purchase(Player player)
        {
            bool result = false;

            if (LandOwner == null)
            {
                LandOwner = player;
                player.Money -= Price;
                result = true;
            }
            return result;
        }
    }
}
