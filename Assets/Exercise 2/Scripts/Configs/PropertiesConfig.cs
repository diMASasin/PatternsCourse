using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    [Serializable]
    public class PropertiesConfig
    {
        [field:SerializeField, Range(0, 10)] public float Speed { get; private set; } = 2;
        [field: SerializeField, Range(0, 20)] public float WorkDuration { get; private set; } = 5;
        [field: SerializeField, Range(0, 20)] public float IdleDuration { get; private set; } = 3;
    }
}