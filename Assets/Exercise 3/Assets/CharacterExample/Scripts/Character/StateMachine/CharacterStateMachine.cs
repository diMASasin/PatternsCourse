using System.Collections.Generic;
using System.Linq;
using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States;
using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.AirbornState;
using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Grounded;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine
{
    public class CharacterStateMachine: StateSwitcher
    {
        private List<State> _states;
        private State _currentState;

        public CharacterStateMachine(Character character)
        {
            StateMachineData data = new StateMachineData();

            _states = new List<State>()
            {
                new IdlingState(this, data, character),
                new RunningState(this, data, character),
                new JumpingState(this, data, character),
                new FallingState(this, data, character),
                new WalkingState(this, data, character),
                new FastRunningState(this, data, character),
            };

            _currentState = _states[0];
            _currentState.Enter();
        }

        public void SwitchState<T>() where T : State
        {
            State state = _states.FirstOrDefault(state => state is T);

            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void HandleInput() => _currentState.HandleInput();

        public void Update() => _currentState.Update();
    }
}
