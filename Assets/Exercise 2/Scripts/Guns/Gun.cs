using Exercise_2.Scripts;
using UnityEngine;

public abstract class Gun
{
    protected GunConfig Config;

    protected int MaxBullets => Config.MaxBullets;
    protected int BulletsPerShot => Config.BulletsPerShot;
    protected int BulletsCount { get; set; }

    public Sprite Sprite => Config.Sprite;
    public abstract bool CanShoot { get; }

    private BulletPool _bulletPool;
    private Transform _spawnPoint;

    public Gun(BulletPool bulletPool, Transform spawnPoint, GunConfig gunConfig)
    {
        _bulletPool = bulletPool;
        _spawnPoint = spawnPoint;
        Config = gunConfig;
        BulletsCount = MaxBullets;
    }

    protected Bullet SpawnBullet()
    {
        Bullet bullet = _bulletPool.GetFreeObject();
        bullet.gameObject.SetActive(true);
        bullet.Launch(_spawnPoint.position, _spawnPoint.rotation);

        return bullet;
    }

    public bool TryShoot()
    {
        if (CanShoot)
            Shoot();
        else
            OnShotImpossible();    

        return CanShoot;
    }
    protected abstract void Shoot();

    protected virtual void OnShotImpossible()
    {
        Debug.Log("NO AMMO");
    }

}
