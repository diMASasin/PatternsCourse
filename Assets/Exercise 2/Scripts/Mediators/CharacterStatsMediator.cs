using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class CharacterStatsMediator : IDisposable
    {
        private readonly Player _player;
        private readonly StatsPanel _statsPanel;

        public CharacterStatsMediator(Player player, StatsPanel statsPanel)
        {
            _player = player;
            _statsPanel = statsPanel;

            _player.HealthChanged += OnHealthChanged;
            _player.ExpirienceChanged += OnExpirienceChanged;
            _player.LevelChanged += OnLevelChanged;
        }

        public void Dispose()
        {
            _player.HealthChanged -= OnHealthChanged;
            _player.ExpirienceChanged -= OnExpirienceChanged;
            _player.LevelChanged -= OnLevelChanged;
        }

        private void OnLevelChanged(int level)
        {
            _statsPanel.OnLevelChanged(level);
        }

        private void OnExpirienceChanged(int expirience, int expirienceToLevelUp)
        {
            _statsPanel.OnExperienceChanged(expirience, expirienceToLevelUp);
        }

        private void OnHealthChanged(int health, int maxHealth)
        {
            _statsPanel.OnHealthChanged(health, maxHealth);
        }
    }
}