    using UnityEngine;

    namespace Assets.Exercise_3.Scripts
    {
        public class AppleTradeBehavior : TradeBehavior
        {
            public AppleTradeBehavior(TradeBehaviorConfig config) : base(config)
            {
            }

            protected override void PlayReaction()
            {
                Debug.Log("[Торговец с обычным выражение лица]");
                Debug.Log("[Торговец предложил фрукты]");
            }
    }
    }
