using System;

namespace Exercise_2.Scripts
{
    public class GunShooter : IDisposable
    {
        private readonly GameInput _gameInput;
        private Gun _gun;

        public GunShooter(GameInput gameInput, Gun gun)
        {
            _gameInput = gameInput;
            _gun = gun;

            _gameInput.GunShotKeyClicked += OnGunShotKeyClicked;
            _gameInput.ReloadGunKeyClicked += OnReloadGunKeyClicked;
        }

        public void Dispose()
        {
            _gameInput.GunShotKeyClicked -= OnGunShotKeyClicked;
            _gameInput.ReloadGunKeyClicked -= OnReloadGunKeyClicked;
        }

        private void OnReloadGunKeyClicked()
        {
            if (_gun is IReloadable reloadable)
                reloadable.Reload();
        }

        private void OnGunShotKeyClicked()
        {
            _gun.TryShoot();
        }

        public void ChangeGun(Gun gun)
        {
            _gun = gun;
        }
    }
}