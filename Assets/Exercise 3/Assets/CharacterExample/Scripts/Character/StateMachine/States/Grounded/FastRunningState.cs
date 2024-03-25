using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Configs;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class FastRunningState : MoveState
    {
        private readonly GroundedStateConfig _config;

        public FastRunningState(StateSwitcher stateSwitcher, StateMachineData data, Character character) : base(
            stateSwitcher, data, character)
            => _config = character.Config.GroundedStateConfig;

        public override void Enter()
        {
            base.Enter();

            View.StartRunning();

            Data.Speed = _config.FastRunningSpeed;
        }

        public override void Exit()
        {
            base.Exit();

            View.StopRunning();
        }
    }
}
