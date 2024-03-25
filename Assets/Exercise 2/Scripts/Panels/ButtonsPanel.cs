using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Exercise_2.Scripts
{
    public class ButtonsPanel : MonoBehaviour
    {
        [SerializeField] private Button _applyDamageButton;
        [SerializeField] private Button _addExpirienceButton;

        public event UnityAction ApplyDamageButtonClicked;
        public event UnityAction AddExpirienceButtonClicked;

        private void OnEnable()
        {
            _addExpirienceButton.onClick.AddListener(OnAddExpirienceButtonClicked);
            _applyDamageButton.onClick.AddListener(OnApplyDamageButtonClicked);
        }

        private void OnDisable()
        {
            _addExpirienceButton.onClick.RemoveListener(OnAddExpirienceButtonClicked);
            _applyDamageButton.onClick.RemoveListener(OnApplyDamageButtonClicked);
        }

        public void OnApplyDamageButtonClicked()
        {
            ApplyDamageButtonClicked?.Invoke();
        }

        public void OnAddExpirienceButtonClicked()
        {
            AddExpirienceButtonClicked?.Invoke();
        }
    }
}