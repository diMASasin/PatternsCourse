using Exercise_3.Scripts.Balloons;
using Exercise_3.Scripts.Configs;
using Exercise_3.Scripts.GameModes;
using Exercise_3.Scripts.GameModes.GameEndConditions;
using Plugins.Zenject.Source.Install;
using UnityEngine;

namespace Exercise_3.Scripts.Installers
{
    public class Installer : MonoInstaller
    {
        [SerializeField] private Transform _balloonsParent;
        [SerializeField] private BalloonSpawnConfig _balloonSpawnConfig;
        [SerializeField] private BalloonsSpawner _balloonsSpawner;
        [SerializeField] private BalloonClicker _balloonClicker;

        public override void InstallBindings()
        {
            BindGameMode();
            BindLevel();
            BindBalloons();
        }

        private void BindLevel()
        {
            Container.Bind<Level>().AsSingle();
        }

        private void BindBalloons()
        {
            Container.Bind<BalloonsFactory>().AsSingle().WithArguments(_balloonsParent);
            Container.BindInstance(_balloonSpawnConfig).AsSingle();
            Container.BindInstance(_balloonClicker).AsSingle();
            Container.BindInstance(_balloonsSpawner).AsSingle();
        }

        private void BindGameMode()
        {
            Container.Bind<GameModeChanger>().AsSingle().NonLazy();
        }
    }
}