using UnityEngine;

namespace Assets.Exercise_3.Scripts
{
    public class Trader : MonoBehaviour
    {
        private TradeBehavior _tradeBehavior;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out IBuyer buyer))
            {
                if(buyer.CanBuy(_tradeBehavior.Item.Price) == false)
                    return;

                if (_tradeBehavior.CanTrade(buyer.Reputation) == false)
                    return;

                Item item = _tradeBehavior.Trade();
                buyer.Buy(item);
            }
        }

        public void ChangeBehavior(TradeBehavior behavior)
        {
            _tradeBehavior = behavior;
        }
    }
}
