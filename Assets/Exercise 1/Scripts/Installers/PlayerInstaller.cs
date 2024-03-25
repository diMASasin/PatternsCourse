using Exercise_1.Scripts.Player;
using Plugins.Zenject.Source.Install;
using UnityEngine;

namespace Exercise_1.Scripts.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player.Player _playerPrefab;
        [SerializeField] private Transform _playerSpawnPoint;

        [SerializeField] private PlayerStatsConfig _playerStatsConfig;

        public override void InstallBindings()
        {
            BindConfig();
            BindInstance();
        }

        private void BindInstance()
        {
            Player.Player player = Container.InstantiatePrefabForComponent<Player.Player>(_playerPrefab, _playerSpawnPoint.position, Quaternion.identity, null);
            Container.BindInterfacesAndSelfTo<Player.Player>().FromInstance(player).AsSingle();
        }

        private void BindConfig()
        {
            Container.Bind<PlayerStatsConfig>().FromInstance(_playerStatsConfig).AsSingle();
        }
    }
}
