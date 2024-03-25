using UnityEngine;

namespace Exercise_2.Scripts
{
    public class WalkState : State
    {
        private Vector3 CurrentPosition => Character.transform.position;

        public WalkState(CharacterStateMachine characterStateMachine, StateMachineData data, Character character) 
            : base(characterStateMachine, data, character)
        {
        }

        public override void Update()
        {
            base.Update();

            var diraction = Data.TargetPosition - CurrentPosition;
            diraction.y = 0;
            Character.Controller.Move(Config.Speed * Time.deltaTime * diraction.normalized);

            float inaccuracy = 0.02f;
            if (diraction.magnitude < inaccuracy && Data.TargetPosition == Data.IdlePosition)
            {
                StateSwitcher.SwitchState<IdlingState>();
            }
            else if (diraction.magnitude < inaccuracy && Data.TargetPosition == Data.JobPosition)
            {
                StateSwitcher.SwitchState<WorkState>();
            }
        }
    }
}