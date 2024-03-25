using UnityEngine;

namespace Assets.Visitor
{
    [CreateAssetMenu(fileName = "EnemyWeightConfig", menuName = "Configs/EnemyWeightConfig", order = 0)]
    public class EnemyWeightConfig : ScriptableObject
    {
        [field: SerializeField] public int Ork { get; private set; } = 20;
        [field: SerializeField] public int Human { get; private set; } = 10;
        [field: SerializeField] public int Elf { get; private set; } = 5;
        [field: SerializeField] public int Robot { get; private set; } = 15;
        [field: SerializeField] public int MaxTotalValue { get; private set; } = 100;
    }
}