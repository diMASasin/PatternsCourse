using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Exercise_2.Scripts
{
    public class StatsPanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text _levelText;
        [SerializeField] private Slider _healthSlider;
        [SerializeField] private Slider _experienceSlider;

        public void OnLevelChanged(int level)
        {
            _levelText.text = "Уровень: " + level.ToString();
        }

        public void OnHealthChanged(int health, int maxHealth)
        {
            _healthSlider.value = (float)health / maxHealth;
        }

        public void OnExperienceChanged(int expirience, int expirienceToLevelUp)
        {
            _experienceSlider.value = (float)expirience / expirienceToLevelUp;
        }
    }
}