using Exercise_3.Scripts.Configs;
using UnityEngine;
using Zenject;

namespace Exercise_3.Scripts.Balloons
{
    public class BalloonsFactory
    {
        private Transform _balloonsParent;

        public BalloonsFactory(Transform balloonsParent)
        {
            _balloonsParent = balloonsParent;
        }

        public Balloon Create(BallonColorConfig config)
        {
            Balloon balloon = Object.Instantiate(config.BalloonPrefab, _balloonsParent);

            return balloon;
        }
    }
}