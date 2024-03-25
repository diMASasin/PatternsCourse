using Excercise_5.Scripts.Specializations;
using System;
using Excercise_5.Scripts.Configs;

namespace Excercise_5.Scripts
{
    public class SpecializationStatProvider : IStateProvider
    {
        private readonly SpecializationTypes _specialization;
        private readonly SpecializationStatsConfig _config;

        public SpecializationStatProvider(SpecializationTypes specialization, SpecializationStatsConfig config)
        {
            _specialization = specialization;
            _config = config;
        }

        public CharacterStats GetStats(CharacterStats stats)
        {
            switch (_specialization)
            {
                case SpecializationTypes.Wizard:
                    return stats + _config.Wizard;

                case SpecializationTypes.Thief:
                    return stats + _config.Thief;

                case SpecializationTypes.Barbarian:
                    return stats + _config.Barbarian;
            }

            throw new ArgumentException(nameof(CharacterStats));
        }
    }
}