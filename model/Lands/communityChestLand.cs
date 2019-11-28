using Monopoly_TD7.model.Lands;
using Monopoly_TD7.model.Lands.StategyPattern;

namespace Monopoly_TD7.model
{
    public class CommunityChestLand : Land
    {
        public CommunityChestLand() => (Type, SealableStrategy) = (LandType.CommunityChest, new NotPurchasableStrategy());

    }
}