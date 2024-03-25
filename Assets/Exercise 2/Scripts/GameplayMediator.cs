using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class GameplayMediator : IDisposable
    {
        private readonly DefeatPanel _defeatPanel;

        private readonly Level _level;

        public GameplayMediator(Level level, DefeatPanel defeatPanel)
        {
            _defeatPanel = defeatPanel;
            _level = level;
            _level.Defeat += OnLevelDefeat;
        }
        
        public void Dispose()
        {
            _level.Defeat -= OnLevelDefeat;
            Debug.Log("Dispose");
        }

        private void OnLevelDefeat() => _defeatPanel.Show();

        public void RestartLevel()
        {
            _defeatPanel.Hide();
            _level.Restart();
        }

    }
}
