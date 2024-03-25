using UnityEngine;
using Zenject;

namespace Exercise_1.Scripts.Player
{
    public class Player : MonoBehaviour, IEnemyTarget
    {
        private int _maxHealth;
        private int _health;

        public Vector3 Position => transform.position;

        [Inject]
        private void Construct(PlayerStatsConfig playerStatsConfig)
        {
            _maxHealth = _health = playerStatsConfig.MaxHealth;
            Debug.Log($"� ���� {_health} ��");
        }

        public void TakeDamage(int damage)
        {
            //�������� �����
            //��������� �����
        }
    }
}
