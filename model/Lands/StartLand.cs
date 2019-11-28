using Monopoly_TD7.model.Lands.StategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class StartLand : Land
    {
        const int REWARD = 200;

        public StartLand() => (Type, SealableStrategy) = (LandType.Start, new NotPurchasableStrategy());

    }
}
