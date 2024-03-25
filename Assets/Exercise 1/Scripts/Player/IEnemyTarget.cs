using UnityEngine;

namespace Exercise_1.Scripts.Player
{
    public interface IEnemyTarget : IDamageable
    {
        Vector3 Position { get; }
    }
}
