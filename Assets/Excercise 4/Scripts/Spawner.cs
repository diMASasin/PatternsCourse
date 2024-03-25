using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Visitor
{
    public class Spawner: MonoBehaviour, IEnemyDeathNotifier, IEnemySpawnNotifier
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;

        private Coroutine _spawn;

        private readonly List<Enemy> _spawnedEnemies = new();

        public event Action<Enemy> Dead;
        public event Action<Enemy> Spawned;

        [ContextMenu("StartWork")]
        public void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        public Enemy GetRandomSpawnedEnemy()
        {
            if (_spawnedEnemies.Count == 0)
                return null;

            return _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)];
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                yield return new WaitForSeconds(_spawnCooldown);

                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                enemy.Died += OnEnemyDied;
                _spawnedEnemies.Add(enemy);
                Spawned?.Invoke(enemy);
            }
        }

        private void OnEnemyDied(Enemy enemy)
        {
            enemy.Died -= OnEnemyDied;
            Dead?.Invoke(enemy);
            _spawnedEnemies.Remove(enemy);
        }
    }
}
