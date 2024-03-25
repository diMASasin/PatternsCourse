using System.Collections.Generic;
using UnityEngine;

namespace Exercise_1.Scripts
{
    [CreateAssetMenu(fileName = "EnemySpawnerConfig", menuName = "EnemyConfigs/EnemySpawnerConfig")]
    public class EnemySpawnerConfig : ScriptableObject
    {
        [field: SerializeField] public MonoBehaviour MonoBehaviour { get; private set; }
        [field: SerializeField, Range(1, 10)] public float SpawnCooldown { get; private set; }
        [field: SerializeField, Range(1, 10)] public List<Transform> SpawnPoints { get; private set; }
    }
}