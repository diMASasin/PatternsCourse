using UnityEngine;

namespace Assets.Exercise_4.Scripts
{
    [CreateAssetMenu(fileName = "BalloonSpawnConfig", menuName = "Configs/BalloonSpawnConfig", order = 0)]
    public class BalloonSpawnConfig : ScriptableObject
    {
        [SerializeField] private BallonColorConfig[] _ballonColorConfigs;
        [field: SerializeField, Range(1, 10)] public int Columns { get; private set; }
        [field: SerializeField] public Vector2 Spacing { get; private set; }

        public BallonColorConfig[] BallonColorConfigs => _ballonColorConfigs;
    }
}