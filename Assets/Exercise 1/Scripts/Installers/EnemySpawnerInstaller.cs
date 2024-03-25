using System.Collections.Generic;
using Exercise_1.Scripts.Enemies;
using Plugins.Zenject.Source.Install;
using UnityEngine;

namespace Exercise_1.Scripts.Installers
{
    public class EnemySpawnerInstaller : MonoInstaller
    {
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private float _spawnCooldown = 1;
        [SerializeField] private CoroutinePerformer _coroutinePerformer;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PauseHandler>().AsSingle();
            Container.Bind<EnemyFactory>().AsSingle().WithArguments(Container);
            Container.Bind<EnemySpawnerData>().AsSingle().WithArguments(_coroutinePerformer, _spawnCooldown, _spawnPoints);
            Container.Bind<EnemySpawner>().AsSingle();
            Container.BindInterfacesAndSelfTo<Bootstrap>().AsSingle().NonLazy();
        }
    }
}
