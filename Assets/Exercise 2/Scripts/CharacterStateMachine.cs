using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class CharacterStateMachine : StateSwitcher
    {
        private readonly List<State> _states;
        private State _currentState;

        public IReadOnlyList<State> States => _states;

        public CharacterStateMachine(Character character, Vector3 idlePosition, Vector3 jobPosition)
        {
            StateMachineData data = new(idlePosition, jobPosition);

            _states = new List<State>()
            {
                new IdlingState(this, data, character),
                new WalkState(this, data, character),
                new WorkState(this, data, character)
            };

            data.TargetPosition = jobPosition;
            _currentState = _states[1];
            _currentState.Enter();
        }

        public void SwitchState<T>() where T : State
        {
            State state = _states.FirstOrDefault(state => state is T);

            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();
    }
}
