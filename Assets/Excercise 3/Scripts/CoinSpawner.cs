using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Excercise_3.Scripts
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private CoinFactory _coinFactory;
        [SerializeField] private Transform _parent;
        [SerializeField] private int _amount;
        [SerializeField] private float _radius;
        [SerializeField] private int _triesToFindPosition = 10;
        [SerializeField] private Color _gizmosColor = new(0.2f, 0.2f, 0.2f, 0.5f);

        private SpawnArea _spawnArea;

        private void Start()
        {
            _spawnArea = new SpawnArea(_triesToFindPosition, _parent, _radius, _gizmosColor);
        }

        [ContextMenu("Spawn")]
        public void Spawn()
        {
            for (int i = 0; i < _amount; i++)
            {
                Coin coin = _coinFactory.Get(GetRandomCoinType(), _parent);
                coin.gameObject.SetActive(false);

                var spawnPoint = _spawnArea.GetAvailablePoint(coin.SphereCollider.radius * coin.transform.localScale.x);

                coin.transform.position = spawnPoint;
                coin.gameObject.SetActive(true);
            }
        }

        private CoinTypes GetRandomCoinType()
        {
            return (CoinTypes)Random.Range(0, Enum.GetValues(typeof(CoinTypes)).Length);
        }

        private void OnDrawGizmos()
        {
            _spawnArea.DrawGizmoDisk(transform, _radius);
        }
    }
}