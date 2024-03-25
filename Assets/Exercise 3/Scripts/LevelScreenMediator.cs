using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

namespace Exercise_3.Scripts
{
    public class LevelScreenMediator : MonoBehaviour, IDisposable
    {
        [SerializeField] private GameObject _failScreen;
        [SerializeField] private GameObject _winScreen;
        [SerializeField] private Button[] _restartButton;

        private Level _level;

        [Inject]
        private void Construct(Level level)
        {
            _level = level;

            _level.Failed += OnFailed;
            _level.Won += OnWon;

            foreach (var button in _restartButton)
                button.onClick.AddListener(OnRestartButtonClicked);
        }

        public void Dispose()
        {
            _level.Failed -= OnFailed;
            _level.Won -= OnWon;

            foreach (var button in _restartButton)
                button.onClick.RemoveListener(OnRestartButtonClicked);
        }

        private void OnWon()
        {
            _winScreen.SetActive(true);
        }

        private void OnFailed()
        {
            _failScreen.SetActive(true);
        }

        private void OnRestartButtonClicked()
        {
            SceneManager.LoadScene(0);
        }
    }
}