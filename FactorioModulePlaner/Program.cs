using System;

namespace FactorioModulePlaner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ItemIronOre = new Item {UniqueKey = "Item.Ore.Iron", Name = "IronOre"};
            var ItemIronPlate = new Item {UniqueKey = "Item.IronPlate", Name = "IronPlate"};
            var Items = new[] {ItemIronOre, ItemIronPlate};

            var crafterFurnace = new Crafter
                {BaseCraftingSpeed = 1.5m, BasePowerConsuption = Watts.CreateKiloWats(180)};
            var Crafters = new[] {crafterFurnace};

            var Recepies = new[]
            {
                new Recipe
                {
                    Output = ItemIronPlate, Input = new[] {(ItemIronOre, 1)}, CraftingTime = TimeSpan.FromSeconds(3.2),
                    UsedCrafters = new[] {crafterFurnace}
                }
            };
        }
    }
}