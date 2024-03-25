using UnityEngine;
using Zenject;

namespace Exercise_2.Scripts
{
    public class MediatorBootstrap : IInitializable, ITickable
    {
        private readonly Level _level;

        public MediatorBootstrap(Level level)
        {
            _level = level;
        }

        public void Initialize()
        {
            _level.Start();
        }

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                _level.OnDefeat();
        }
    }
}
