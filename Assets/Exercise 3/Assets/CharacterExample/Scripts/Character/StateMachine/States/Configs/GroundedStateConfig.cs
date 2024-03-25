using System;
using UnityEngine;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Configs
{
    [Serializable]
    public class GroundedStateConfig
    {
        [SerializeField, Range(0, 5)] private float _walkingSpeed;
        [SerializeField, Range(0, 10)] private float _runningSpeed;
        [SerializeField, Range(0, 20)] private float _fastRunningSpeed;

        public float RunningSpeed => _runningSpeed; 
        public float WalkingSpeed => _walkingSpeed; 
        public float FastRunningSpeed => _fastRunningSpeed; 
    }
}
