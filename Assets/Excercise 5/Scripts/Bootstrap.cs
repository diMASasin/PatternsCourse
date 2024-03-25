using Excercise_5.Scripts.Configs;
using Excercise_5.Scripts.Specializations;
using UnityEngine;

namespace Excercise_5.Scripts
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CharacterStats _initialCharacterStats = new(10, 10, 10);
        [SerializeField] private PassiveAbilityStatsConfig _passiveAbilityStatsConfig;
        [SerializeField] private RaceStatsConfig _raceStatsConfig;
        [SerializeField] private SpecializationStatsConfig _specializationStatsConfig;

        private Character _character;

        private void Start()
        {
            CharacterBuilder builder = new(_initialCharacterStats);

            _character = builder
                .SetRace(RaceTypes.Elf, _raceStatsConfig)
                .SetSpecialization(SpecializationTypes.Thief, _specializationStatsConfig)
                .SetPassiveAbility(PassiveAbilityTypes.PassiveInteligence, _passiveAbilityStatsConfig)
                .Build();

            _character.Stats.Print();
        }
    }
}