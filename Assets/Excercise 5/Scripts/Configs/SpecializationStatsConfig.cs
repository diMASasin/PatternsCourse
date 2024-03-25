using UnityEngine;

namespace Excercise_5.Scripts.Configs
{
    [CreateAssetMenu(fileName = "SpecializationStatsConfig", menuName = "Stats/SpecializationStatsConfig",
        order = 0)]
    public class SpecializationStatsConfig : ScriptableObject
    {
        [field: SerializeField] public CharacterStats Barbarian { get; private set; }
        [field: SerializeField] public CharacterStats Thief { get; private set; }
        [field: SerializeField] public CharacterStats Wizard { get; private set; }
    }
}