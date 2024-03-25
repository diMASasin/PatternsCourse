using System.Collections.Generic;
using UnityEngine;

namespace Assets.Exercise_3.Scripts
{
    [CreateAssetMenu(fileName = "TradeLevelsConfig", menuName = "Configs/TradeLevelsConfig")]
    public class TradeBehaviorConfigs : ScriptableObject
    {
        [SerializeField] private List<TradeBehaviorConfig> _configs = new();

        public IReadOnlyList<TradeBehaviorConfig> Configs => _configs;
    }
}