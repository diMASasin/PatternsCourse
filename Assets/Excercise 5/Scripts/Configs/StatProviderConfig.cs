using UnityEngine;

namespace Excercise_5.Scripts.Configs
{
    [CreateAssetMenu(fileName = "StatProviderConfig", menuName = "Configs/StatProviderConfig")]
    public class StatProviderConfig : ScriptableObject
    {
        [SerializeField] private CharacterStats[] _characterStats = new CharacterStats[3];

    }
}