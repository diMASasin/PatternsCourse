using Excercise_2.Scripts.Resources;
using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
    [SerializeField] private Image _coinImage;
    [SerializeField] private Image _energyImage;
    [SerializeField] private IconsFactory _iconsFactory;

    [ContextMenu("CreateIcons")]
    private void CreateIcons()
    {
        Resource coin = _iconsFactory.GetCoin();
        Resource energy = _iconsFactory.GetEnergy();

        _coinImage.sprite = coin.Sprite;
        _energyImage.sprite = energy.Sprite;

        coin.DoSomethingVeryCool();
        energy.DoSomethingVeryCool();
    }
}
