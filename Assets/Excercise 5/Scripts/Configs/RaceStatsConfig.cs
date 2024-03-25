using UnityEngine;

namespace Excercise_5.Scripts.Configs
{
    [CreateAssetMenu(fileName = "RaceStatsConfig", menuName = "Stats/RaceStatsConfig", order = 0)]
    public class RaceStatsConfig : ScriptableObject
    {
        [field: SerializeField] public CharacterStats Elf { get; private set; }
        [field: SerializeField] public CharacterStats Human { get; private set; }
        [field: SerializeField] public CharacterStats Ork { get; private set; }
    }
}