using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    abstract public class Land
    {
        public LandType Type { get; set; }
        public int Position { get; set; }
        public int building;

        public enum LandType
        {
            Start,
            Property,
            GoToJail,
            VisitJail,
            CommunityChest,
            FreePark,
            Tax,
            RailRoad,
            Chance,
            Company

        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}