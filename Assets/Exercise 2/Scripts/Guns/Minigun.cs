using Exercise_2.Scripts;
using UnityEngine;

public class Minigun : Gun
{
    public override bool CanShoot => true;

    public Minigun(BulletPool bulletPool, Transform spawnPoint, GunConfig config) : base(bulletPool, spawnPoint, config)
    { }

    protected override void Shoot()
    {
        SpawnBullet();
    }
}
