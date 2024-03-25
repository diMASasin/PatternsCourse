using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Exercise_4.Scripts
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private GameObject _failScreen;
        [SerializeField] private GameObject _winScreen;

        private BalloonClicker _balloonClicker;
        private GameEndCondition _gameEndCondition;

        public void Init(GameEndCondition endCondition, BalloonClicker balloonClicker)
        {
            _gameEndCondition = endCondition;
            _balloonClicker = balloonClicker;

            _gameEndCondition.Completed += OnCompleted;
            _gameEndCondition.Lost += OnLost;
        }

        public void OnDestroy()
        {
            _gameEndCondition.Completed -= OnCompleted;
            _gameEndCondition.Lost -= OnLost;
        }

        public void Restart()
        {
            SceneManager.LoadScene(0);
        }

        private void OnLost()
        {
            Debug.Log("Lost");
            _failScreen.gameObject.SetActive(true);
            _balloonClicker.enabled = false;
        }

        private void OnCompleted()
        {
            Debug.Log("Completed");
            _winScreen.gameObject.SetActive(true);
            _balloonClicker.enabled = false;
        }
    }
}