using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Exercise_3.Scripts
{
    public class TraderBehaviourSwitcher : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Trader _trader;
        [SerializeField] private TradeBehaviorConfigs _config;

        private List<TradeBehavior> _behaviors = new();
        private TradeBehaviorFactory _behaviorFactory = new();

        private void Awake()
        {
            foreach (var behavior in _config.Configs)
            {
                var newBehavior = _behaviorFactory.Create(behavior);
                _behaviors.Add(newBehavior);
            }
        }

        private void OnEnable()
        {
            _player.ReputationChanged += OnReputationChanged;
        }

        private void OnDisable()
        {
            _player.ReputationChanged -= OnReputationChanged;
        }

        private void OnReputationChanged(int reputation)
        {
            TradeBehavior newBehavior = _behaviors
                .Where(behavior => behavior.RequiredReputation <= reputation)
                .OrderByDescending(behavior => behavior.RequiredReputation)
                .First();

            if (newBehavior == null)
                throw new ArgumentNullException(nameof(TradeBehavior));

            _trader.ChangeBehavior(newBehavior);
        }
    }
}