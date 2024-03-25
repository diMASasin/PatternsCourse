using System;
using UnityEngine;

namespace Assets.Exercise_3.Scripts
{
    [Serializable]
    public class Item
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int Price { get; private set; }

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Item(Item item)
        {
            Name = item.Name;
            Price = item.Price;
        }
    }
}