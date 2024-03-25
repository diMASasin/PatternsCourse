namespace Exercise_2.Scripts
{
    public interface StateSwitcher
    {
        void SwitchState<T>() where T : State;
    }

    
}