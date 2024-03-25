using Exercise_2.Scripts;
using UnityEngine;

public class Pistol : Gun, IReloadable
{
    public override bool CanShoot => BulletsCount > 0;

    public Pistol(BulletPool bulletPool, Transform spawnPoint, GunConfig config) : base(bulletPool, spawnPoint, config)
    { }

    protected override void Shoot()
    {
        SpawnBullet();
        BulletsCount--;
    }

    public void Reload()
    {
        BulletsCount = MaxBullets;
        Debug.Log("Reloaded");
    }
}
