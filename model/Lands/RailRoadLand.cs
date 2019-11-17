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

        public RailRoadLand() => (Type, Position) = (LandType.RailRoad, Position);
        public RailRoadLand(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
