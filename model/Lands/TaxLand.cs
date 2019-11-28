using Monopoly_TD7.model.Lands.StategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class TaxLand : Land
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public TaxLand() => (Type, SealableStrategy) = (LandType.Tax, new NotPurchasableStrategy());

        public TaxLand(string name, double price)
        {
            Name = name;
            Price = price;
            this.Type = LandType.Tax;
        }
    }
}
