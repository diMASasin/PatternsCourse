using UnityEngine;

namespace Excercise_3.Scripts
{
    public abstract class Coin : MonoBehaviour
    {
        [field: SerializeField] public SphereCollider SphereCollider { get; set; }

        public bool IsCollidingWithCoin;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ICoinPicker coinPicker))
            {
                Debug.Log("������������� ������ ������� �������");
                Debug.Log("������������� ���������");

                AddCoins(coinPicker);

                Destroy(gameObject);
            }
        }

        protected abstract void AddCoins(ICoinPicker coinPicker);
    }
}
