namespace FactorioModulePlaner
{
    public struct Joules
    {
        public static Joules None { get; } = new Joules{Value = 0};

        public decimal Value { get; set; }
    }
}