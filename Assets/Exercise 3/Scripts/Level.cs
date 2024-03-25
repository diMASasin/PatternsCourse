using System;
using System.Collections.Generic;
using Exercise_3.Scripts.Balloons;
using Exercise_3.Scripts.GameModes.GameEndConditions;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Exercise_3.Scripts
{
    public class Level
    {
        private List<Balloon> _balloons;
        private IGameEndCondition _gameEndCondition;

        public event Action Failed;
        public event Action Won;
        public event Action Restarted;

        [Inject]
         private void Construct(IGameEndCondition gameEndCondition)
         {
             _gameEndCondition = gameEndCondition;
         }

         public void Init(List<Balloon> balloons)
         {
             _balloons = balloons;

             foreach (var balloon in _balloons)
                 balloon.WasBurst += OnBalloonBurst;
         }

         public void Restart()
         {
             _balloons.Clear();
             Restarted?.Invoke();
         }

         private void OnBalloonBurst(Balloon balloon)
         {
             _balloons.Remove(balloon);
             TryEndGame();
         }

         private void TryEndGame()
         {
             if (_gameEndCondition.IsFail(_balloons))
                 Failed?.Invoke();
             else if (_gameEndCondition.IsWin(_balloons))
                 Won?.Invoke();
         }
    }
}