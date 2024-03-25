using Exercise_2.Scripts;
using UnityEngine;

public class Shotgun : Gun, IReloadable
{
    public override bool CanShoot => BulletsCount >= BulletsPerShot;

    public Shotgun(BulletPool bulletPool, Transform spawnPoint, GunConfig config) : base(bulletPool, spawnPoint, config)
    { }

    protected override void Shoot()
    {
        for (int i = 0; i < BulletsPerShot; i++)
        {
            var bullet = SpawnBullet();
            bullet.transform.rotation = Quaternion.AngleAxis(Random.Range(-45, 45), Vector3.back);
        }

        BulletsCount -= 3;
    }

    public void Reload()
    {
        BulletsCount = MaxBullets;
        Debug.Log("Reloaded");
    }
}
