using System;
using System.Collections.Generic;
using UnityEngine;

namespace Exercise_2.Scripts
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private LosePanel _losePanel;
        [SerializeField] private Player _player;
        [SerializeField] private Enemy _enemy;
        [SerializeField] private ButtonsPanel _buttonsPanel;
        [SerializeField] private StatsPanel _statsPanel;
        [SerializeField] private Level _level;

        private readonly List<IDisposable> _toDispose = new();

        private void Start()
        {
            _toDispose.Add(new PlayerLosePanelMediator(_player, _losePanel));
            _toDispose.Add(new CharacterButtonMediator(_buttonsPanel, _enemy, _player));
            _toDispose.Add(new CharacterStatsMediator(_player, _statsPanel));
            _toDispose.Add(new LevelLosePanelMediator(_losePanel, _level));
        }

        private void OnDestroy()
        {
            _toDispose.ForEach(item => item.Dispose());
        }
    }
}