using UnityEngine;

namespace Assets.Visitor
{
    [CreateAssetMenu(fileName = "EnemyScoreConfig", menuName = "Configs/EnemyScoreConfig", order = 0)]
    public class EnemyScoreConfig : ScriptableObject
    {
        [field: SerializeField] public int Ork { get; private set; } = 20;
        [field: SerializeField] public int Human { get; private set; } = 5;
        [field: SerializeField] public int Elf { get; private set; } = 10;
        [field: SerializeField] public int Robot { get; private set; } = 15;
    }
}