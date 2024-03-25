using UnityEngine;

namespace Exercise_2.Scripts
{
    [CreateAssetMenu(fileName = "GunConfig", menuName = "Configs/GunConfig", order = 0)]
    public class GunConfig : ScriptableObject
    {
        [field: SerializeField, Range(1, 1000)] public int BulletsPerShot { get; private set; }
        [field: SerializeField, Range(1, 10000)] public int MaxBullets { get; private set; }
        [field: SerializeField] public Sprite Sprite { get; private set; }
    }
}