using System;
using UnityEngine;

namespace Assets.Exercise_3.Scripts
{
    [CreateAssetMenu(fileName = "TradeBehaviorConfig", menuName = "Configs/TradeBehaviorConfig", order = 0)]
    [Serializable]
    public class TradeBehaviorConfig : ScriptableObject
    {
        [field: SerializeField] public int RequiredReputation { get; private set; }
        [field: SerializeField] public TradeBehaviorTypes BehaviorType { get; private set; }
        [field: SerializeField] public Item Item { get; private set; } = new("Ничего", 0);
    }
}