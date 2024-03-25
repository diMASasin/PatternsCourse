using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class PlayerLosePanelMediator : IDisposable
    {
        private readonly Player _player;
        private readonly LosePanel _losePanel;

        public PlayerLosePanelMediator(Player player, LosePanel losePanel)
        {
            _player = player;
            _losePanel = losePanel;

            _player.Died += OnDied;
        }

        public void Dispose()
        {
            _player.Died -= OnDied;
        }

        private void OnDied()
        {
            _losePanel.Show();
        }
    }
}