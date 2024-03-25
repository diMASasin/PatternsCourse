using UnityEngine;

namespace Excercise_5.Scripts.Configs
{
    [CreateAssetMenu(fileName = "PassiveAbilityStatsConfig", menuName = "Stats/PassiveAbilityStatsConfig",
        order = 0)]
    public class PassiveAbilityStatsConfig : ScriptableObject
    {
        [field: SerializeField] public CharacterStats Agility { get; private set; }
        [field: SerializeField] public CharacterStats Strength { get; private set; }
        [field: SerializeField] public CharacterStats Intelligece { get; private set; }
    }
}