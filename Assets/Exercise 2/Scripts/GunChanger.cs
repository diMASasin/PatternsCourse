using System;
using System.Collections.Generic;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class GunChanger
    {
        private List<Gun> _guns = new();
        private GunFactory _gunFactory;
        private GameInput _gameInput;

        public Gun Gun { get; private set; }

        public event Action<Gun> GunChanged;

        public GunChanger(GunFactory gunFactory, GameInput gameInput)
        {
            _gunFactory = gunFactory;
            _gameInput = gameInput;

            _gameInput.PickGunKeyClicked += OnPickGunKeyClicked;

            _guns.Add(_gunFactory.GetGun(GunTypes.Pistol));
            _guns.Add(_gunFactory.GetGun(GunTypes.Minigun));
            _guns.Add(_gunFactory.GetGun(GunTypes.Shotgun));
        }

        private void OnPickGunKeyClicked(int index)
        {
            ChangeGun(index);
        }

        public void ChangeGun(GunTypes type)
        {
            Gun = _guns[(int)type];
            GunChanged?.Invoke(Gun);
            Debug.Log($"{Gun.GetType()} picked up");
        }

        private void ChangeGun(int index)
        {
            Gun = _guns[index];
            GunChanged?.Invoke(Gun);
            Debug.Log($"{Gun.GetType()} picked up");
        }
    }
}