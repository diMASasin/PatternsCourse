using System.Collections.Generic;
using UnityEngine;

namespace Exercise_1.Scripts.Enemies
{
    public class EnemySpawnerData
    {
        public readonly ICoroutinePerformer CoroutinePerformer;
        public readonly float SpawnCooldown;
        public readonly List<Transform> SpawnPoints;

        public EnemySpawnerData(ICoroutinePerformer coroutinePerformer, float spawnCooldown, List<Transform> spawnPoints)
        {
            CoroutinePerformer = coroutinePerformer;
            SpawnCooldown = spawnCooldown;
            SpawnPoints = spawnPoints;
        }
    }
}