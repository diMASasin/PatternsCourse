using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Exercise_1.Scripts.Enemies
{
    public class EnemySpawner : IPause
    {
        private readonly EnemyFactory _enemyFactory;
        private readonly EnemySpawnerData _data;

        private Coroutine _spawn;
        private bool _isPaused;

        private List<Transform> SpawnPoints => _data.SpawnPoints;

        [Inject]
        public EnemySpawner(EnemyFactory enemyFactory, PauseHandler pauseHandler, EnemySpawnerData data)
        {
            _enemyFactory = enemyFactory;
            _data = data;
            pauseHandler.Add(this);
        }

        public void StartWork()
        {
            Debug.Log("EnemySpawner");
            StopWork();

            _spawn = _data.CoroutinePerformer.StartRoutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                _data.CoroutinePerformer.StopRoutine(Spawn());
        }

        public void SetPause(bool isPause) => _isPaused = isPause;

        private IEnumerator Spawn()
        {
            float time = 0;

            while (true)
            {
                while (time < _data.SpawnCooldown)
                {
                    if(_isPaused == false)
                        time += Time.deltaTime;

                    yield return null;
                }

                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(SpawnPoints[Random.Range(0, SpawnPoints.Count)].position);
                time = 0;
            }
        }
    }
}
