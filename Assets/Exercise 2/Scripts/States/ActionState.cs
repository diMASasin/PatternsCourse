using System.Timers;

namespace Exercise_2.Scripts
{
    public class ActionState : State
    {
        private readonly Timer _timer = new();

        public ActionState(CharacterStateMachine characterStateMachine, StateMachineData data, Character character) :
            base(characterStateMachine, data, character)
        { }

        public override void Enter()
        {
            base.Enter();
            const int second = 1000;
            _timer.Interval = Config.WorkDuration * second;
            _timer.AutoReset = true;
            _timer.Start();
            _timer.Elapsed += OnTimerElapsed;
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs args)
        {
            _timer.Elapsed -= OnTimerElapsed;
            StateSwitcher.SwitchState<WalkState>();
        }
    }
}