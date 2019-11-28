using Monopoly_TD7.model.Lands.StategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class RailRoadLand :Land
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Player LandOwner { get ; set ; }

        public RailRoadLand() => (Type, SealableStrategy) = (LandType.RailRoad, new PurchasableStrategy(Price));

        public RailRoadLand(string name, double price)
        {
            Name = name;
            Price = price;
            this.Type = LandType.RailRoad;
            SealableStrategy = new PurchasableStrategy(Price);
        }

        public void Purchase(Player player)
        {
            LandOwner = player;
            player.Money -= this.Price;
        }
    }
}
