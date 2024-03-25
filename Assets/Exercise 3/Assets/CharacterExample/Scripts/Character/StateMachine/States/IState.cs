namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States
{
    public interface State 
    {
        void Enter();
        void Exit();
        void HandleInput();
        void Update();
    }
}
