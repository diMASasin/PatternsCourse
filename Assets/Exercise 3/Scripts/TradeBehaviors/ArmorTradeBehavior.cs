using UnityEngine;

    namespace Assets.Exercise_3.Scripts
    {
        public class ArmorTradeBehavior : TradeBehavior
        {
            public ArmorTradeBehavior(TradeBehaviorConfig config) : base(config)
            {
            }

            protected override void PlayReaction()
            {
                Debug.Log("[Торговец обрадовался]");
                Debug.Log("[Торговец предложил лучшие виды брони]");
            }
        }
    }
