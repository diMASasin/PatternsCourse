using Excercise_2.Scripts.Resources;
using UnityEngine;

namespace Excercise_2.Scripts
{
    [CreateAssetMenu(fileName = "ResourcesConfig", menuName = "Configs/ResourcesConfig")]
    public class ResourcesConfig : ScriptableObject
    {
        [field: SerializeField] public Resource Coin { get; private set; }
        [field: SerializeField] public Resource Energy { get; private set; }
    }
}