using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Configs;
using UnityEngine.InputSystem;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class RunningState : MoveState
    {
        private readonly GroundedStateConfig _config;

        public RunningState(StateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
            => _config = character.Config.GroundedStateConfig;

        public override void Enter()
        {
            base.Enter();

            View.StartRunning();

            Data.Speed = _config.RunningSpeed;

            Input.Movement.ChangeMovementType.started += OnChangeMovementType;
        }

        public override void Exit()
        {
            base.Exit();

            View.StopRunning();

            Input.Movement.ChangeMovementType.started -= OnChangeMovementType;
        }

        private void OnChangeMovementType(InputAction.CallbackContext obj) => StateSwitcher.SwitchState<FastRunningState>();
    }
}
