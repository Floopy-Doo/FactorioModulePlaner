using System.Diagnostics;

namespace FactorioModulePlaner
{
    [DebuggerDisplay("Value W")]
    public struct Watts
    {
        public static Watts CreateKiloWats(decimal kilowatts) => new Watts(kilowatts * 1000);

        private Watts(decimal value)
        {
            Value = value;
        }

        private decimal Value { get; set; }

        public static Watts operator *(Watts nominator, decimal multiplier) =>
            new Watts { Value = nominator.Value * multiplier };
    }
}