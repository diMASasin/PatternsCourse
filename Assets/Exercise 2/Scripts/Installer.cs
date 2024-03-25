using Plugins.Zenject.Source.Install;
using UnityEngine;

namespace Exercise_2.Scripts
{
    internal class Installer : MonoInstaller
    {
        [SerializeField] private DefeatPanel _defeatPanel;

        public override void InstallBindings()
        {
            Container.Bind<Level>().AsSingle();
            Container.Bind<GameplayMediator>().AsSingle();
            Container.BindInstance(_defeatPanel).AsSingle();
            Container.BindInterfacesAndSelfTo<MediatorBootstrap>().AsSingle();
        }
    }
}
