using System;
using UnityEngine;

namespace Assets.Exercise_3.Scripts
{
    [Serializable]
    public class TradeBehavior
    {
        public Item Item => _config.Item;
        public int RequiredReputation => _config.RequiredReputation;
        public TradeBehaviorTypes BehaviorType => _config.BehaviorType;

        private readonly TradeBehaviorConfig _config;

        public TradeBehavior(TradeBehaviorConfig config)
        {
            _config = config;
        }

        public bool CanTrade(int reputation)
        {
            if (reputation < 0)
                throw new ArgumentOutOfRangeException(nameof(reputation));

            if(reputation >= RequiredReputation)
                PlayReaction();

            return reputation >= RequiredReputation && RequiredReputation >= 0;
        }

        protected virtual void PlayReaction()
        {
            Debug.Log("[Торговец сделал недовольное лицо]");
            Debug.Log("[Торговец прикрыл товар полотном]");
            Debug.Log("[Торговец сказал: \"Чет гавном завоняло\"]");
        }

        public Item Trade()
        {
            Debug.Log($"Продал {Item.Name}");
            return new Item(Item);
        }
    }
}