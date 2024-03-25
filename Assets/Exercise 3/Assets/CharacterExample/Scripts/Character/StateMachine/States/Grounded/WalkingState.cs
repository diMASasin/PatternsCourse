using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Configs;
using UnityEngine.InputSystem;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class WalkingState : MoveState
    {
        private readonly GroundedStateConfig _config;

        public WalkingState(StateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher,
            data, character)
            => _config = character.Config.GroundedStateConfig;

        public override void Enter()
        {
            base.Enter();

            View.StartRunning();

            Data.Speed = _config.WalkingSpeed;

            Input.Movement.ChangeMovementType.started += OnChangeMovementType;
        }

        public override void Exit()
        {
            base.Exit();

            View.StopRunning();

            Input.Movement.ChangeMovementType.started -= OnChangeMovementType;
        }

        private void OnChangeMovementType(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<RunningState>();
    }
}
