using UnityEngine;

namespace Exercise_2.Scripts
{
    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] private GunConfig _pistol;
        [SerializeField] private GunConfig _minigun;
        [SerializeField] private GunConfig _shotgun;
        [SerializeField] private BulletPool _bulletPool;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Player _player;

        private GunFactory _gunFactory;

        private void Awake()
        {
            _gunFactory = new GunFactory(_bulletPool, _spawnPoint, _pistol, _minigun, _shotgun);
            _player.Init(_gunFactory);
        }
    }
}