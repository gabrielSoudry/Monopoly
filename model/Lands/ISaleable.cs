using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    interface ISaleable
    {
        void Purchase(Player player);
        Player LandOwner { get; set; }

    }
}
