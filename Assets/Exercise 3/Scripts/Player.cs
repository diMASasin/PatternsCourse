using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Exercise_3.Scripts
{
    public class Player : MonoBehaviour, IBuyer
    {
        [SerializeField] private float _speed;
        [SerializeField] private int _money = 100;

        private List<Item> _items = new();

        public int Reputation { get; private set; }

        public event Action<int> ReputationChanged;

        private void Awake()
        {
            ReputationChanged?.Invoke(Reputation);
        }

        private void Update()
        {
            var direction = Input.GetAxis("Horizontal");

            transform.Translate(direction * Time.deltaTime * _speed, 0, 0);

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Reputation++;
                Debug.Log($"Reputation: {Reputation}");
                ReputationChanged?.Invoke(Reputation);
            }
        }

        public void Buy(Item item)
        {
            _money -= item.Price;
            _items.Add(item);
            Debug.Log("Осталось денег: " + _money);
        }

        public bool CanBuy(int price)
        {
            return _money >= price;
        }

    }
}