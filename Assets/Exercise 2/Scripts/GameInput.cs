using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class GameInput
    {
        public event Action<int> PickGunKeyClicked;
        public event Action GunShotKeyClicked;
        public event Action ReloadGunKeyClicked;

        public void Tick()
        {
            if (Input.GetMouseButtonDown(0))
                GunShotKeyClicked?.Invoke();

            KeyCode keyCode = KeyCode.Alpha1;
            if (Input.GetKeyDown(keyCode))
                PickGun(keyCode);

            keyCode = KeyCode.Alpha2;
            if (Input.GetKeyDown(keyCode))
                PickGun(keyCode);

            keyCode = KeyCode.Alpha3;
            if (Input.GetKeyDown(keyCode))
                PickGun(keyCode);

            if (Input.GetKeyDown(KeyCode.R))
                ReloadGunKeyClicked?.Invoke();
        }

        private void PickGun(KeyCode keyCode)
        {
            PickGunKeyClicked?.Invoke((int)keyCode % 49);
        }
    }
}