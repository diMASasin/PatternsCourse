using System;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine
{
    public class StateMachineData 
    {
        public float XVelocity;
        public float YVelocity;

        public MovementType MovementType;

        private float _speed;
        private float _xInput;

        public float XInput
        {
            get => _xInput;
            set
            {
                if(value < -1 || value > 1)
                    throw new ArgumentOutOfRangeException(nameof(value));

                _xInput = value;
            }
        }

        public float Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));

                _speed = value;
            }
        }
    }

    public enum MovementType
    {
        Walk,
        Run,
        FastRun
    }
}