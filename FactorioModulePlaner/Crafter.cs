using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FactorioModulePlaner
{
    public class Crafter
    {
        public decimal BaseCraftingSpeed { get; set; }

        public decimal EffectiveCraftingSpeed => 
            Boosters.Aggregate(BaseCraftingSpeed, (speed, booster) => speed * booster.CraftingSpeedMultiplier);

        public Watt BasePowerConsuption { get; set; }

        public Watt EffectivePowerConsuption =>
            Boosters.Aggregate(BasePowerConsuption, (power, booster) => power * booster.PowerMultiplier);

        public ICollection<Booster> Boosters { get; } = new Collection<Booster>();
    }
}