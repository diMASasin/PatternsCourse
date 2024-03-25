using UnityEngine;

namespace Exercise_2.Scripts
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterStateMachine _characterStateMachine;
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private CharacterConfig _characterConfig;

        [field: SerializeField] public Transform JobTransform { get; private set; }

        public CharacterController Controller => _characterController;
        public CharacterConfig Config => _characterConfig;

        private void Start()
        {
            _characterStateMachine = new CharacterStateMachine(this, transform.position, JobTransform.position);
        }

        private void Update()
        {
            _characterStateMachine.Update();
        }

        public void Move()
        {
            _characterController.Move(JobTransform.position);

        }
    }
}