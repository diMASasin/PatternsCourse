using UnityEngine;

namespace Exercise_2.Scripts
{
    public class IdlingState : ActionState
    {

        public IdlingState(CharacterStateMachine characterStateMachine, StateMachineData data, Character character) 
            : base(characterStateMachine, data, character)
        {
        }

        public override void Update()
        {
            base.Update();
            Debug.Log("[Отдыхаю]");
        }

        public override void Exit()
        {
            base.Exit();
            Data.TargetPosition = Data.JobPosition;
        }
    }
}