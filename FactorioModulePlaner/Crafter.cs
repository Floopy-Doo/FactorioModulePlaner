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

        public Watts BasePowerConsuption { get; set; }

        public Watts EffectivePowerConsuption =>
            Boosters.Aggregate(BasePowerConsuption, (power, booster) => power * booster.PowerMultiplier);

        public ICollection<IBooster> Boosters { get; } = new Collection<IBooster>();
    }
}