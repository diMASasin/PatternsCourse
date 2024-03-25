using UnityEngine;

namespace Exercise_2.Scripts
{
    public abstract class State
    {
        public readonly StateSwitcher StateSwitcher;
        public readonly Character Character;
        public readonly StateMachineData Data;

        public PropertiesConfig Config => Character.Config.PropertiesConfig;

        protected State(CharacterStateMachine characterStateMachine, StateMachineData data, Character character)
        {
            StateSwitcher = characterStateMachine;
            Character = character;
            Data = data;
        }

        public virtual void Enter()
        {
            Debug.Log(GetType());
        }

        public virtual void Exit()
        {
        }

        public virtual void Update()
        {
        }
    }
}