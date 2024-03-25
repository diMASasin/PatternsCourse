using System;
using UnityEngine;

namespace Assets.Visitor
{
    public class Score: IDisposable
    {
        public int Value => _enemyVisitor.Score;

        private readonly IEnemyDeathNotifier _enemyDeathNotifier;

        private readonly EnemyVisitor _enemyVisitor;

        public Score(IEnemyDeathNotifier enemyDeathNotifier, EnemyScoreConfig scoreConfig)
        {
            _enemyDeathNotifier = enemyDeathNotifier;

            _enemyDeathNotifier.Dead += OnEnemyKilled;

            _enemyVisitor = new EnemyVisitor(scoreConfig);
        }

        public void Dispose() => _enemyDeathNotifier.Dead -= OnEnemyKilled;

        private void OnEnemyKilled(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);
            Debug.Log($"—чет: {Value}");
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            private readonly EnemyScoreConfig _scoreConfig;

            public int Score { get; private set; }

            public EnemyVisitor(EnemyScoreConfig scoreConfig)
            {
                _scoreConfig = scoreConfig;
            }

            public void Visit(Ork ork) => Score += _scoreConfig.Ork;

            public void Visit(Human human) => Score += _scoreConfig.Human;

            public void Visit(Elf elf) => Score += _scoreConfig.Elf;

            public void Visit(Robot robot) => Score += _scoreConfig.Robot;

            public void Visit(Enemy enemy) => Visit((dynamic) enemy);
        }
    }
}
