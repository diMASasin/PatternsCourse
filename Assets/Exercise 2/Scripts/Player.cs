using Exercise_2.Scripts;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GunChanger _gunChanger;
    [SerializeField] private GunView _gunView;

    private readonly GameInput _gameInput = new();
    private GunShooter _gunShooter;

    public void Init(GunFactory gunFactory)
    {
        _gunChanger = new GunChanger(gunFactory, _gameInput);
        _gunShooter = new GunShooter(_gameInput, _gunChanger.Gun);
    }

    private void Start()
    {
        _gunChanger.ChangeGun(GunTypes.Pistol);
    }

    private void OnEnable()
    {
        _gunChanger.GunChanged += OnGunChanged;
    }

    private void OnDisable()
    {
        _gunChanger.GunChanged -= OnGunChanged;
    }

    private void OnDestroy()
    {
        _gunShooter.Dispose();
    }

    private void OnGunChanged(Gun gun)
    {
        _gunView.SetSprite(gun.Sprite);
        _gunShooter.ChangeGun(gun);
    }

    private void Update()
    {
        _gameInput.Tick();
    }
}