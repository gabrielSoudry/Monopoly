using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class PropertyLand : Land
    {
        public Player Ownedby { get; set; }
        public double Price { get; set; }
        public String Name { get; set; }
        public int [] Multipledrent { get; set; }
        public string Color { get; set; }


        public PropertyLand ()=> (Type,Position) = (LandType.Property,Position);

        public PropertyLand(double price, string name,int[] multipledrent, string color)
        {
            Type = LandType.Property;
            Ownedby = null;
            Price = price;
            Name = name;
            Multipledrent = multipledrent;
            Color = color;
        }
    }
}
