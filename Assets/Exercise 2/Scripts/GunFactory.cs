using System.ComponentModel;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class GunFactory
    {
        [SerializeField] private GunConfig _pistol;
        [SerializeField] private GunConfig _minigun;
        [SerializeField] private GunConfig _shotgun;

        private readonly BulletPool _bulletPool;
        private readonly Transform _spawnPoint;

        public GunFactory(BulletPool bulletPool, Transform spawnPoint, GunConfig pistol, GunConfig minigun, GunConfig shotgun)
        {
            _bulletPool = bulletPool;
            _spawnPoint = spawnPoint;
            _pistol = pistol;
            _minigun = minigun;
            _shotgun = shotgun;
        }

        public Gun GetGun(GunTypes gunTypes)
        {
            switch (gunTypes)
            {
                case GunTypes.Minigun:
                    return new Minigun(_bulletPool, _spawnPoint, _minigun);

                case GunTypes.Pistol:
                    return new Pistol(_bulletPool, _spawnPoint, _pistol);

                case GunTypes.Shotgun:
                    return new Shotgun(_bulletPool, _spawnPoint, _shotgun);

                default:
                    throw new InvalidEnumArgumentException(nameof(GunTypes));
            }
        }
    }

    
}