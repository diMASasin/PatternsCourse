using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine
{
    public interface StateSwitcher
    {
        void SwitchState<T>() where T : State;
    }
}
