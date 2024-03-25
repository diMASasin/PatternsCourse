using System;
using Excercise_5.Scripts.Configs;

namespace Excercise_5.Scripts.StatProviders
{
    public class RaceStatProvider : IStateProvider
    {
        private readonly RaceTypes _race;
        private readonly RaceStatsConfig _config;

        public RaceStatProvider(RaceTypes race, RaceStatsConfig config)
        {
            _race = race;
            _config = config;
        }

        public CharacterStats GetStats(CharacterStats stats)
        {
            switch (_race)
            {
                case RaceTypes.Elf:
                    return stats + _config.Elf;

                case RaceTypes.Human:
                    return stats + _config.Human;

                case RaceTypes.Ork:
                    return stats + _config.Ork;
            }

            throw new ArgumentException(nameof(CharacterStats));
        }
    }
}