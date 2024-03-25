using System;
using System.Collections.Generic;

namespace Assets.Exercise_4.Scripts
{
    public abstract class GameEndCondition : IDisposable
    {
        protected List<Balloon> Balloons;

        public event Action Completed;
        public event Action Lost;

        protected GameEndCondition(List<Balloon> balloons)
        {
            Balloons = balloons;

            foreach (var balloon in Balloons)
                balloon.WasBurst += OnBurst;
        }

        public void Dispose()
        {
            foreach (var balloon in Balloons)
                balloon.WasBurst -= OnBurst;
        }

        private void OnBurst(Balloon balloon)
        {
            Balloons.Remove(balloon);

            if(IsWin())
                Completed?.Invoke();
            if(IsFail(balloon.Color))
                Lost?.Invoke();
        }

        public abstract bool IsWin();

        public abstract bool IsFail(BalloonColors burstBalloonColor);
    }
}