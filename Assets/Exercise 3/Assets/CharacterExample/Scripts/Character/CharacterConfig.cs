using Exercise_3.Assets.CharacterExample.Scripts.Character.StateMachine.States.Configs;
using UnityEngine;

namespace Exercise_3.Assets.CharacterExample.Scripts.Character
{
    [CreateAssetMenu(menuName = "Configs/PropertiesConfig", fileName = "PropertiesConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private GroundedStateConfig groundedStateConfig;
        [SerializeField] private AirbornStateConfig _airbornStateConfig;

        public GroundedStateConfig GroundedStateConfig => groundedStateConfig;
        public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
    }
}
