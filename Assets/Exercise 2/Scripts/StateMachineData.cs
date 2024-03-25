using UnityEngine;

namespace Exercise_2.Scripts
{
    public class StateMachineData
    {
        public readonly Vector3 IdlePosition;
        public readonly Vector3 JobPosition;
        public Vector3 TargetPosition;

        public StateMachineData(Vector3 idlePosition, Vector3 jobPosition)
        {
            IdlePosition = idlePosition;
            JobPosition = jobPosition;
        }
    }
}