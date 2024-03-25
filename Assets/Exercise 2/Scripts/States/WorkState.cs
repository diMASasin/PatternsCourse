using UnityEngine;

namespace Exercise_2.Scripts
{
    public class WorkState : ActionState
    {
        public WorkState(CharacterStateMachine characterStateMachine, StateMachineData data, Character character) 
            : base(characterStateMachine, data, character)
        {
        }

        public override void Update()
        {
            base.Update();
            Debug.Log("[Работаю]");
        }

        public override void Exit()
        {
            base.Exit();
            Data.TargetPosition = Data.IdlePosition;
        }
    }
}