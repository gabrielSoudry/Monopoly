using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands.StategyPattern
{
    public class NotPurchasableStrategy : SealableStrategy
    {
        public override bool Purchase(Player player)
        {
            return false; // This land connot be purshased
        }
    }
}
