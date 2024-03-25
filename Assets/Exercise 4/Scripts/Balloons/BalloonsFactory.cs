using UnityEngine;

namespace Assets.Exercise_4.Scripts
{
    public class BalloonsFactory
    {
        private readonly Transform _balloonsContainer;

        public BalloonsFactory(Transform balloonsContainer)
        {
            _balloonsContainer = balloonsContainer;
        }

        public Balloon Create(BallonColorConfig config)
        {
            Balloon balloon = Object.Instantiate(config.BalloonPrefab, Vector3.zero, Quaternion.identity, _balloonsContainer);
            balloon.Init(config.BalloonColor);

            return balloon;
        }
    }
}