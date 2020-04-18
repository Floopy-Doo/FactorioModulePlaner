using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FactorioModulePlaner
{
    public class Recipe
    {
        public Item Output { get; set; }

        public IEnumerable<(Item, int)> Input { get; set; } 

        public TimeSpan CraftingTime { get; set; }

        public IEnumerable<Crafter> UsedCrafters { get; set; } = new Collection<Crafter>();

        public IEnumerable<Booster> AllowedBoosters { get; set; } = new Collection<Booster>();
    }
}