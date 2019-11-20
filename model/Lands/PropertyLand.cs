using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class PropertyLand : Land, ISaleable
    {
       
        public double Price { get; set; }
        public String Name { get; set; }
        public int [] Multipledrent { get; set; }
        public string Color { get; set; }
        public Player LandOwner { get ; set ; }

        public PropertyLand ()=> (Type,Position) = (LandType.Property,Position);

        public PropertyLand(double price, string name,int[] multipledrent, string color)
        {
            Type = LandType.Property;
            Price = price;
            Name = name;
            Multipledrent = multipledrent;
            Color = color;
        }

        public override string ToString()
        {
            return Name;
        }

        public void Purchase(Player player)
        {
            LandOwner = player;
            Console.WriteLine(player.Money);
            Console.WriteLine(this.Price);
            player.Money -= this.Price;
            GameMasters a = GameMasters.Instance;
            Console.WriteLine(a.Players[0].Money);
        }
    }
}
