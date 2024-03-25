using System;
using UnityEngine;

namespace Assets.Visitor
{
    public class Weight
    {
        private readonly EnemyVisitor _enemyVisitorAddWeight;
        private readonly EnemyVisitor _enemyVisitorSubstructWeight;

        private bool _maxValueReached;

        public int MaxValue { get; set; }

        public int Value => EnemyVisitor.Weight;

        public event Action MaxValueReached;
        public event Action MaxValueUnreached;

        public Weight(EnemyWeightConfig weightConfig)
        {
            _enemyVisitorAddWeight = new EnemyVisitor(weightConfig, (a, b) => a + b);
            _enemyVisitorSubstructWeight = new EnemyVisitor(weightConfig, (a, b) => a - b);

            MaxValue = weightConfig.MaxTotalValue;
        }

        public void OnDead(Enemy enemy)
        {
            _enemyVisitorSubstructWeight.Visit(enemy);
            Debug.Log($"Вес: {Value}");

            if (_maxValueReached == true && Value < MaxValue)
            {
                _maxValueReached = false;
                MaxValueUnreached?.Invoke();
            }
        }

        public void OnEnemySpawned(Enemy enemy)
        {
            _enemyVisitorAddWeight.Visit(enemy);
            Debug.Log($"Вес: {Value}");

            if (Value >= MaxValue)
            {
                MaxValueReached?.Invoke();
                _maxValueReached = true;
            }
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public static int Weight { get; private set; }

            private readonly EnemyWeightConfig _weightConfig;
            private readonly Func<int, int, int> _action;

            public EnemyVisitor(EnemyWeightConfig weightConfig, Func<int, int, int> action)
            {
                _weightConfig = weightConfig;
                _action = action;
            }

            public void Visit(Enemy enemy) => Visit((dynamic)enemy);

            public void Visit(Ork ork) => Weight = _action(Weight, _weightConfig.Ork);

            public void Visit(Human human) => Weight = _action(Weight, _weightConfig.Human);

            public void Visit(Elf elf) => Weight = _action(Weight, _weightConfig.Elf);

            public void Visit(Robot robot) => Weight = _action(Weight, _weightConfig.Robot);
        }
    }
}