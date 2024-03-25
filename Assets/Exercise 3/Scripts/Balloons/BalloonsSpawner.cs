using System.Collections.Generic;
using System.Linq;
using Exercise_3.Scripts.Configs;
using UnityEngine;
using Zenject;

namespace Exercise_3.Scripts.Balloons
{
    public class BalloonsSpawner : MonoBehaviour
    {
        [SerializeField] private Transform _balloonsParent;
        
        private BalloonSpawnConfig _spawnConfig;
        private BalloonsFactory _balloonsFactory;
        private Vector3? _nextPosition;
        private int _leftToSpawn;
        private int _spawnedBalloons;
        private int[] _amounts;

        [Inject]
        public void Construct(BalloonsFactory balloonsFactory, BalloonSpawnConfig spawnConfig)
        {
            _balloonsFactory = balloonsFactory;
            _spawnConfig = spawnConfig;

            _amounts = _spawnConfig.BallonColorConfigs.Select(config => config.Amount).ToArray();
            _leftToSpawn = _amounts.Sum();
        }

        public List<Balloon> Spawn()
        {
            List<Balloon> balloons = new();

            while (_leftToSpawn-- != 0)
            {
                int colorIndex = GetRandomConfigIndex();
                
                Balloon balloon = _balloonsFactory.Create(_spawnConfig.BallonColorConfigs[colorIndex]);
                balloons.Add(balloon);
                _amounts[colorIndex]--;
                _spawnedBalloons++;

                balloon.transform.position = _nextPosition ?? _balloonsParent.position;

                CalculateNextPosition(balloon);
            }

            return balloons;
        }

        private int GetRandomConfigIndex()
        {
            int colorIndex;
            do
            {
                colorIndex = Random.Range(0, _amounts.Length);
            } while (_amounts[colorIndex] == 0);

            return colorIndex;
        }

        private void CalculateNextPosition(Balloon balloon)
        {
            Transform balloonTransform = balloon.transform;

            _nextPosition = balloonTransform.position +
                            (balloonTransform.localScale.x + _spawnConfig.Spacing.x) * Vector3.right;

            Vector3 nextPosition = _nextPosition.Value;

            if (_spawnedBalloons % _spawnConfig.Columns == 0)
            {
                _nextPosition = new Vector3(
                    _balloonsParent.position.x,
                    nextPosition.y - balloon.transform.localScale.y - _spawnConfig.Spacing.y,
                    nextPosition.z);
            }
        }
    }
}