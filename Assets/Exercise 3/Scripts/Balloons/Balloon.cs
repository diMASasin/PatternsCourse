using System;
using UnityEngine;

namespace Exercise_3.Scripts.Balloons
{
    public class Balloon : MonoBehaviour
    {
        [field: SerializeField] public BalloonColors Color { get; private set; }

        public event Action<Balloon> WasBurst;

        public void Burst()
        {
            WasBurst?.Invoke(this);
            Destroy(gameObject);
        }
    }
}