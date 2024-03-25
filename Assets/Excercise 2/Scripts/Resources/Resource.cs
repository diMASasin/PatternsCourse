using System;
using UnityEngine;

namespace Excercise_2.Scripts.Resources
{
    [Serializable]
    public class Resource
    {
        [field: SerializeField] public Sprite Sprite { get; set; }

        public Resource(Sprite sprite)
        {
            Sprite = sprite;
        }

        public virtual void DoSomethingVeryCool()
        {
            Debug.Log(GetType().Name);
        }
    }
}