using System;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class CharacterButtonMediator : IDisposable
    {
        private readonly ButtonsPanel _buttonsPanel;
        private readonly Enemy _enemy;
        private readonly Player _player;

        public CharacterButtonMediator(ButtonsPanel buttonsPanel, Enemy enemy, Player player)
        {
            _buttonsPanel = buttonsPanel;
            _enemy = enemy;
            _player = player;

            _buttonsPanel.ApplyDamageButtonClicked += OnApplyDamageButtonDown;
            _buttonsPanel.AddExpirienceButtonClicked += OnAddExpirienceButtonDown;
        }

        public void Dispose()
        {
            _buttonsPanel.ApplyDamageButtonClicked -= OnApplyDamageButtonDown;
            _buttonsPanel.AddExpirienceButtonClicked -= OnAddExpirienceButtonDown;
        }

        private void OnApplyDamageButtonDown()
        {
            _player.TakeDamage(_enemy.Damage);
        }

        private void OnAddExpirienceButtonDown()
        {
            _player.GetExperience(_enemy.ExpirienceForKill);
        }
    }
}