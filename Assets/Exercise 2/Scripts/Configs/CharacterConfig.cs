using UnityEngine;

namespace Exercise_2.Scripts
{
    [CreateAssetMenu(menuName = "Configs/CharacterConfig2", fileName = "CharacterConfig2")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private PropertiesConfig propertiesConfig;

        public PropertiesConfig PropertiesConfig => propertiesConfig;
    }
}