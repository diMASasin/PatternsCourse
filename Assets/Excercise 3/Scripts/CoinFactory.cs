using System.ComponentModel;
using UnityEngine;

namespace Excercise_3.Scripts
{
    [CreateAssetMenu(fileName = "CoinFactory", menuName = "Factories/CoinFactory")]
    public class CoinFactory : ScriptableObject
    {
        [SerializeField] private Coin _emptyCoinPrefab;
        [SerializeField] private Coin _randomCoinPrefab;
        [SerializeField] private Coin _standartCoinPrefab;

        public Coin Get(CoinTypes coinTypes,Transform parent)
        {
            switch (coinTypes)
            {
                case CoinTypes.Empty:
                    return Instantiate(_emptyCoinPrefab, parent);

                case CoinTypes.Random:
                    return Instantiate(_randomCoinPrefab, parent);

                case CoinTypes.Standart:
                    return Instantiate(_standartCoinPrefab, parent);

                default:
                    throw new InvalidEnumArgumentException(nameof(CoinFactory));
            }
        }
    }
}