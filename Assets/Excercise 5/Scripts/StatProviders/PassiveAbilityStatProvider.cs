using System;
using Excercise_5.Scripts.Configs;

namespace Excercise_5.Scripts
{
    public class PassiveAbilityStatProvider : IStateProvider
    {
        private readonly PassiveAbilityTypes _passiveAbility;
        private readonly PassiveAbilityStatsConfig _config;

        public PassiveAbilityStatProvider(PassiveAbilityTypes passiveAbility, PassiveAbilityStatsConfig config)
        {
            _passiveAbility = passiveAbility;
            _config = config;
        }

        public CharacterStats GetStats(CharacterStats stats)
        {
            switch (_passiveAbility)
            {
                case PassiveAbilityTypes.PassiveAgility:
                    return stats * _config.Agility;

                case PassiveAbilityTypes.PassiveStrength:
                    return stats * _config.Strength;

                case PassiveAbilityTypes.PassiveInteligence:
                    return stats * _config.Intelligece;
            }

            throw new ArgumentException(nameof(CharacterStats));
        }
    }
}