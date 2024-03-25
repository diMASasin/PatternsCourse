using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Grounded;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.AirbornState
{
    public class FallingState : AirbornState
    {
        private readonly GroundChecker _groundChecker;

        public FallingState(StateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
            => _groundChecker = character.GroundChecker;

        public override void Enter()
        {
            base.Enter();

            View.StartFalling();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopFalling();
        }

        public override void Update()
        {
            base.Update();

            if (_groundChecker.IsTouches)
            {
                Data.YVelocity = 0;

                StateSwitcher.SwitchState<IdlingState>();
            }
        }
    }
}
