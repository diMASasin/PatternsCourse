using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Exercise_4.Scripts
{
    public class LevelEndChanger : MonoBehaviour
    {
        [SerializeField] private Button _sameColorBallonsButton;
        [SerializeField] private Button _allBalloonsButton;

        private List<Balloon> _balloons;

        public event Action<GameEndCondition> LevelEndChanged;

        public void Init(List<Balloon> balloons)
        {
            _balloons = balloons;
        }

        private void OnEnable()
        {
            _sameColorBallonsButton.onClick.AddListener(OnSameColorBallonsButtonClicked);
            _allBalloonsButton.onClick.AddListener(OnAllBallonsButtonClicked);
        }

        private void OnDisable()
        {
            _sameColorBallonsButton.onClick.RemoveListener(OnSameColorBallonsButtonClicked);
            _allBalloonsButton.onClick.RemoveListener(OnAllBallonsButtonClicked);
        }

        private void OnAllBallonsButtonClicked()
        {
            HideWindow();

            var levelEnd = new AllBalloonsBurst(_balloons);
            LevelEndChanged?.Invoke(levelEnd);
        }

        private void OnSameColorBallonsButtonClicked()
        {
            HideWindow();

            var levelEnd = new SameColorBalloonsBurst(_balloons);
            LevelEndChanged?.Invoke(levelEnd);
        }

        private void HideWindow()
        {
            gameObject.SetActive(false);
        }
    }
}