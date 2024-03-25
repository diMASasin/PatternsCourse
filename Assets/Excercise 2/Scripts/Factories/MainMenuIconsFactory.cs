using Excercise_2.Scripts.Resources;
using UnityEngine;

namespace Excercise_2.Scripts.Factories
{
    [CreateAssetMenu(fileName = "MainMenuIconsFactory", menuName = "Factories/MainMenuIconsFactory")]
    public class MainMenuIconsFactory : IconsFactory
    {
        public override Resource GetCoin()
        {
            return new MainMenuCoin(Config.Coin.Sprite);
        }

        public override Resource GetEnergy()
        {
            return new MainMenuEnergy(Config.Energy.Sprite);
        }
    }
}