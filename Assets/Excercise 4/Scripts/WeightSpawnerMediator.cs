using System;
using Unity.VisualScripting;

namespace Assets.Visitor
{
    public class WeightSpawnerMediator : IDisposable
    {
        private readonly Weight _weight;
        private readonly Spawner _spawner;
        private readonly IEnemySpawnNotifier _spawnNotifier;
        private readonly IEnemyDeathNotifier _deathNotifier;

        public WeightSpawnerMediator(Weight weight, Spawner spawner)
        {
            _weight = weight;
            _spawner = spawner;
            _spawnNotifier = _spawner;
            _deathNotifier = _spawner;

            _weight.MaxValueReached += StopWork;
            _weight.MaxValueUnreached += StartWork;
            _spawnNotifier.Spawned += OnEnemySpawned;
            _deathNotifier.Dead += OnDead;
        }

        public void Dispose()
        {
            _weight.MaxValueReached -= StopWork;
            _weight.MaxValueUnreached -= StartWork;
            _spawnNotifier.Spawned -= OnEnemySpawned;
            _deathNotifier.Dead -= OnDead;
        }

        private void StartWork()
        {
            _spawner.StartWork();
        }

        private void StopWork()
        {
            _spawner.StopWork();
        }

        private void OnDead(Enemy enemy)
        {
            _weight.OnDead(enemy);
        }

        private void OnEnemySpawned(Enemy enemy)
        {
            _weight.OnEnemySpawned(enemy);
        }
    }
}