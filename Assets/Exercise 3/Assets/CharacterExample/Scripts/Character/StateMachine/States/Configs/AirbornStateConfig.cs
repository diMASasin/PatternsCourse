using System;
using UnityEngine;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Configs
{
    [Serializable]
    public class AirbornStateConfig
    {
        [SerializeField] private JumpingStateConfig _jumpingStateConfig;

        [SerializeField, Range(0, 15f)] private float _speed;

        public float Speed => _speed;

        public JumpingStateConfig JumpingStateConfig => _jumpingStateConfig;

        public float BaseGravity
            => 2f * _jumpingStateConfig.MaxHeight / (_jumpingStateConfig.TimeToReachMaxHeight * _jumpingStateConfig.TimeToReachMaxHeight);
    }
}
