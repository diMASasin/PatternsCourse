using UnityEngine;
using Zenject;

namespace Exercise_1.Scripts.Enemies
{
    public class Bootstrap : ITickable, IInitializable
    {
        private EnemySpawner _spawner;

        private PauseHandler _pauseHandler;

        [Inject]
        private void Construct(PauseHandler pauseHandler, EnemySpawner enemySpawner)
        {
            _pauseHandler = pauseHandler;
            _spawner = enemySpawner;
        }

        public void Initialize()
        {
            _spawner.StartWork();
        }

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.F))
                _pauseHandler.SetPause(true);

            if(Input.GetKeyDown(KeyCode.S))
                _pauseHandler.SetPause(false);
        }
    }
}
