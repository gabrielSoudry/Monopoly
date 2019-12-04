using Monopoly_TD7.model.Lands.StategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class CompanyLand : Land
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public Player LandOwner { get ; set ; }

        public CompanyLand() => (Type, SealableStrategy) = (LandType.Company,new NotPurchasableStrategy());

        public CompanyLand(string name, double price)
        {
            Name = name;
            Price = price;
            this.Type = LandType.Company;
        }

        public void Purchase(Player player)
        {
            #if DEBUG
            Console.WriteLine(this.Price);
            #endif
            LandOwner = player;
            player.Money -= this.Price;
        }
    }
}
