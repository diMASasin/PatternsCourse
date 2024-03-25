using Excercise_5.Scripts.Configs;
using Excercise_5.Scripts.Specializations;
using Excercise_5.Scripts.StatProviders;

namespace Excercise_5.Scripts
{
    public class CharacterBuilder
    {
        private readonly CharacterStats _initialStats;

        private RaceStatProvider _race;
        private SpecializationStatProvider _specialization;
        private PassiveAbilityStatProvider _passiveAbility;

        public CharacterBuilder(CharacterStats initialStats)
        {
            _initialStats = initialStats;
        }

        public CharacterBuilder SetRace(RaceTypes race, RaceStatsConfig raceStatsConfig)
        {
            _race = new RaceStatProvider(race, raceStatsConfig);

            return this;
        }

        public CharacterBuilder SetSpecialization(SpecializationTypes specializationTypes, 
            SpecializationStatsConfig specializationStatsConfig)
        {
            _specialization = new SpecializationStatProvider(specializationTypes, specializationStatsConfig);

            return this;
        }

        public CharacterBuilder SetPassiveAbility(PassiveAbilityTypes passiveAbilityTypes, 
            PassiveAbilityStatsConfig passiveAbilityStatsConfig)
        {
            _passiveAbility = new PassiveAbilityStatProvider(passiveAbilityTypes, passiveAbilityStatsConfig);

            return this;
        }

        public Character Build()
        {
            return new Character(_passiveAbility.GetStats(_specialization.GetStats(_race.GetStats(_initialStats))));
        }
    }
}