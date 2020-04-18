using System.Diagnostics;
using FactorioModulePlaner;

namespace FactorioModulePlaner
{
    [DebuggerDisplay("{Value}W")]
    public struct Watt
    {

        public Watt(decimal value)
        {
            this.Value = value;
        }

        private decimal Value { get; set; }

        public static Watt FromMegaWatts(decimal megawatst) => 
            FromKiloWatts(megawatst * 1000);

        public static Watt FromKiloWatts(decimal kilowatts) => 
            FromWatts(kilowatts * 1000);

        public static Watt FromWatts(decimal watts) => 
            new Watt(watts);
        
        public static implicit operator Watt(decimal value) => 
            FromWatts(value);
        public static Watt operator *(Watt nominator, decimal multiplier) =>
            new Watt { Value = nominator.Value * multiplier };
    }
}