using System.Collections.Generic;

namespace Assets.Exercise_4.Scripts
{
    public class SameColorBalloonsBurst : GameEndCondition
    {
        private BalloonColors? _balloonColor;

        public SameColorBalloonsBurst(List<Balloon> balloons) : base(balloons)
        {
        }

        public override bool IsFail(BalloonColors burstBalloonColor)
        {
            _balloonColor ??= burstBalloonColor;

            return _balloonColor.Value != burstBalloonColor;
        }

        public override bool IsWin()
        {
            return Balloons.Exists(balloon => balloon.Color == BalloonColors.White) == false ||
                    Balloons.Exists(balloon => balloon.Color == BalloonColors.Green) == false ||
                    Balloons.Exists(balloon => balloon.Color == BalloonColors.Red) == false;
        }
    }
}