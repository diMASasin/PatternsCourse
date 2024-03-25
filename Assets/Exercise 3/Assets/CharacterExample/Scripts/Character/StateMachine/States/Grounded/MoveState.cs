using UnityEngine.InputSystem;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class MoveState : GroundedState
    {
        public MoveState(StateSwitcher stateSwitcher, StateMachineData data, Character character)
            : base(stateSwitcher, data, character)
        {
        }

        protected override void AddInputActionCallbacks()
        {
            base.AddInputActionCallbacks();

            Input.Movement.ChangeMovementType.started += OnChangeMovementType;
        }

        protected override void RemoveInputActionCallbacks()
        {
            base.RemoveInputActionCallbacks();

            Input.Movement.ChangeMovementType.started -= OnChangeMovementType;
        }

        public override void Update()
        {
            base.Update();

            if (IsHorizontalInputZero())
                StateSwitcher.SwitchState<IdlingState>();
        }

        private void OnChangeMovementType(InputAction.CallbackContext obj)
        {
            if (Data.MovementType + 1 > MovementType.FastRun)
                Data.MovementType = 0;
            else
                Data.MovementType++;

            StateSwitcher.SwitchState<IdlingState>();
        }
    }
}