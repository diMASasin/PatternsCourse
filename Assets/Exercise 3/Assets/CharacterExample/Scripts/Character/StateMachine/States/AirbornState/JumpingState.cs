using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Configs;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.AirbornState
{
    public class JumpingState : AirbornState
    {
        private readonly JumpingStateConfig _config;

        public JumpingState(StateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
            => _config = character.Config.AirbornStateConfig.JumpingStateConfig;

        public override void Enter()
        {
            base.Enter();

            View.StartJumping();

            Data.YVelocity = _config.StartYVelocity;
        }

        public override void Exit()
        {
            base.Exit();

            View.StopJumping();
        }

        public override void Update()
        {
            base.Update();

            if (Data.YVelocity <= 0)
                StateSwitcher.SwitchState<FallingState>();
        }
    }
}
