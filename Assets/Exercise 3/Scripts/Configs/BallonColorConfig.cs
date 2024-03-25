using System;
using Exercise_3.Scripts.Balloons;
using UnityEngine;

namespace Exercise_3.Scripts.Configs
{
    [Serializable]
    public class BallonColorConfig
    {
        [field: SerializeField] public Balloon BalloonPrefab { get; private set; }
        [field: SerializeField] public int Amount { get; private set; }

        public BalloonColors BalloonColor => BalloonPrefab.Color;
    }
}