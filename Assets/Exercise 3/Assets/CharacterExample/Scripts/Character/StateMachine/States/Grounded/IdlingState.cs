namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class IdlingState : GroundedState
    {
        public IdlingState(StateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        {
        }

        public override void Enter()
        {
            base.Enter();

            View.StartIdling();

            Data.Speed = 0;
        }

        public override void Exit()
        {
            base.Exit();

            View.StopIdling();
        }

        public override void Update()
        {
            base.Update();

            if (IsHorizontalInputZero())
                return;

            switch (Data.MovementType)
            {
                case MovementType.Walk:
                    StateSwitcher.SwitchState<WalkingState>();
                    break;
                case MovementType.FastRun:
                    StateSwitcher.SwitchState<FastRunningState>();
                    break;
                default: 
                    StateSwitcher.SwitchState<RunningState>();
                    break;
            }
        }
    }
}
