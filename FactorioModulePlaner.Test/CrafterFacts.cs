using FluentAssertions;
using Xunit;

namespace FactorioModulePlaner.Test
{
    public class CrafterFacts
    {
        [Fact]
        public void ShouldCalculateEffectiveCraftingSpeedWithoutBoostersWhenNoBoostersArePresent()
        {
            const decimal exectedSpeed = 1;

            Crafter testee = new Crafter
            {
                BaseCraftingSpeed = exectedSpeed
            };

            testee.EffectiveCraftingSpeed.Should().Be(exectedSpeed);
        }

        [Fact]
        public void ShouldCalculateEffectiveCraftingSpeedWithoutBoostersWhenBoostersArePresent()
        {
            const decimal initialSpeed = 1;
            const decimal exectedSpeed = 1.2m;

            var testee = new Crafter
            {
                BaseCraftingSpeed = initialSpeed,
                Boosters = { new Booster { CraftingSpeedMultiplier = 1.2m } }
            };

            testee.EffectiveCraftingSpeed.Should().Be(exectedSpeed);
        }

        [Fact]
        public void ShouldCalculateEffectiveCraftingSpeedWithoutBoostersWhenMultipleBoostersArePresent()
        {
            const decimal initialSpeed = 1;
            const decimal exectedSpeed = 1.8m;

            var testee = new Crafter
            {
                BaseCraftingSpeed = initialSpeed,
                Boosters =
                {
                    new Booster { CraftingSpeedMultiplier = 1.2m },
                    new Booster { CraftingSpeedMultiplier = 1.5m }
                }
            };

            testee.EffectiveCraftingSpeed.Should().Be(exectedSpeed);
        }


        [Fact]
        public void ShouldCalculateEffectivePowerConsumptionWithoutBoostersWhenNoBoostersArePresent()
        {
            const Watt exectedSpeed = 1;

            Crafter testee = new Crafter
            {
                BasePowerConsumption = exectedSpeed
            };

            testee.EffectivePowerConsumption.Should().Be(exectedSpeed);
        }

        [Fact]
        public void ShouldCalculateEffectivePowerConsumptionWithoutBoostersWhenBoostersArePresent()
        {
            const decimal initialSpeed = 1;
            const decimal exectedSpeed = 1.2m;

            var testee = new Crafter
            {
                BasePowerConsumption = initialSpeed,
                Boosters = { new Booster { PowerConsumptionMultiplier = 1.2m } }
            };

            testee.EffectivePowerConsumption.Should().Be(exectedSpeed);
        }

        [Fact]
        public void ShouldCalculateEffectivePowerConsumptionWithoutBoostersWhenMultipleBoostersArePresent()
        {
            const decimal initialSpeed = 1;
            const decimal exectedSpeed = 1.8m;

            var testee = new Crafter
            {
                BasePowerConsumption = initialSpeed,
                Boosters =
                {
                    new Booster { PowerConsumptionMultiplier = 1.2m },
                    new Booster { PowerConsumptionMultiplier = 1.5m }
                }
            };

            testee.EffectivePowerConsumption.Should().Be(exectedSpeed);
        }
    }
}