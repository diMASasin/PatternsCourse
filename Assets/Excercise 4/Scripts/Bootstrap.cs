using Assets.Visitor;
using UnityEngine;

namespace Excercise_4.Scripts
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private EnemyWeightConfig _enemyWeightConfig;

        private Weight _weight;
        private WeightSpawnerMediator _weightSpawnerMediator;

        private void Start()
        {
            _weight = new Weight(_enemyWeightConfig);
            _weightSpawnerMediator = new WeightSpawnerMediator(_weight, _spawner);
        }

        public void OnDestroy()
        {
            _weightSpawnerMediator.Dispose();
        }
    }
}