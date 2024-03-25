using Excercise_2.Scripts.Resources;
using UnityEngine;

namespace Excercise_2.Scripts.Factories
{
    [CreateAssetMenu(fileName = "ShopIconsFactory", menuName = "Factories/ShopIconsFactory")]
    public class ShopIconsFactory : IconsFactory
    {
        public override Resource GetCoin()
        {
            return new ShopCoin(Config.Coin.Sprite);
        }

        public override Resource GetEnergy()
        {
            return new ShopEnergy(Config.Energy.Sprite);
        }
    }
}