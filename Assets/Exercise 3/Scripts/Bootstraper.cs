using System.Collections.Generic;
using Exercise_3.Scripts.Balloons;
using Plugins.Zenject.Source.Main;
using UnityEngine;
using Zenject;

namespace Exercise_3.Scripts
{
    public class Bootstraper : MonoBehaviour
    {
        private BalloonsSpawner _spawner;
        private BalloonClicker _clicker;
        private Level _level;

        [Inject]
        private void Construct(Level level, BalloonsSpawner spawner, BalloonClicker clicker)
        {
            _level = level;
            _spawner = spawner;
            _clicker = clicker;
        }

        private void Start()
        {
            _clicker.enabled = false;
            List<Balloon> balloons = _spawner.Spawn();
            _clicker.enabled = true;
            _level.Init(balloons);
        }
    }
}
