using System;
using UnityEngine;

namespace Assets.Exercise_4.Scripts
{
    [Serializable]
    public class BallonColorConfig
    {
        [field: SerializeField] public BalloonColors BalloonColor { get; private set; }
        [field: SerializeField] public Balloon BalloonPrefab { get; private set; }
        [field: SerializeField] public int Amount { get; private set; }

    }
}