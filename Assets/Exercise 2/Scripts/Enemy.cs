using UnityEngine;

namespace Exercise_2.Scripts
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] public int Damage { get; private set; }
        [field: SerializeField] public int ExpirienceForKill { get; private set; }
    }
}