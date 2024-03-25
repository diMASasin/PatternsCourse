using System.ComponentModel;

namespace Assets.Exercise_3.Scripts
{
    public class TradeBehaviorFactory
    {
        public TradeBehavior Create(TradeBehaviorConfig behaviorConfig)
        {
            switch (behaviorConfig.BehaviorType)
            {
                case TradeBehaviorTypes.TradeBehavior:
                    return new TradeBehavior(behaviorConfig);

                case TradeBehaviorTypes.AppleTradeBehavior:
                    return new AppleTradeBehavior(behaviorConfig);

                case TradeBehaviorTypes.ArmorTradeBehavior:
                    return new ArmorTradeBehavior(behaviorConfig);

                default:
                    throw new InvalidEnumArgumentException(nameof(TradeBehaviorTypes));
            }
        }
    }
}