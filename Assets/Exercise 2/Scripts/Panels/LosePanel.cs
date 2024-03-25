using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Exercise_2.Scripts
{
    public class LosePanel : MonoBehaviour
    {
        [SerializeField] private Button _restartButton;
        [SerializeField] private CanvasGroup _canvasGroup;

        public event UnityAction RestartButtonClicked;

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(OnRestartButtonClicked);
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(OnRestartButtonClicked);
        }

        public void OnRestartButtonClicked()
        {
            Hide();
            RestartButtonClicked?.Invoke();
        }

        public void Show()
        {
            _canvasGroup.alpha = 1;
            _canvasGroup.interactable = true;
            _canvasGroup.blocksRaycasts = true;
        }

        public void Hide()
        {
            _canvasGroup.alpha = 0;
            _canvasGroup.interactable = false;
            _canvasGroup.blocksRaycasts = false;
        }
    }
}