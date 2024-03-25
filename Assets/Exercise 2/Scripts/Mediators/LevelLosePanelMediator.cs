using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class LevelLosePanelMediator : IDisposable
    {
        private readonly LosePanel _losePanel;
        private readonly Level _level;

        public LevelLosePanelMediator(LosePanel losePanel, Level level)
        {
            _losePanel = losePanel;
            _level = level;

            _losePanel.RestartButtonClicked += OnRestartLoseClicked;
        }
        
        public void Dispose()
        {
            _losePanel.RestartButtonClicked -= OnRestartLoseClicked;
        }

        private void OnRestartLoseClicked()
        {
            _level.Restart();
        }
    }
}