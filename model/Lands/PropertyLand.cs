using Monopoly_TD7.model.Lands.StategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class PropertyLand : Land
    {
       
        public double Price { get; set; }
        public String Name { get; set; }
        public int [] Multipledrent { get; set; }
        public string Color { get; set; }
        public Player LandOwner { get ; set ; }

        public PropertyLand ()=> (Type,Position,SealableStrategy) = (LandType.Property,Position, new PurchasableStrategy(Price));

        public PropertyLand(double price, string name,int[] multipledrent, string color)
        {
            Type = LandType.Property;
            Price = price;
            Name = name;
            Multipledrent = multipledrent;
            Color = color;
            SealableStrategy = new PurchasableStrategy(Price);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
