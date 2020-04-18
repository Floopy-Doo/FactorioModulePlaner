namespace FactorioModulePlaner
{
    public class Item
    {
        public string UniqueKey { get; set; }

        public string Name { get; set; }

        public Joules Power { get; set; } = Joules.None;
    }
}