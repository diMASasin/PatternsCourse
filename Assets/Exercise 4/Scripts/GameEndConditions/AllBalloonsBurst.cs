using System.Collections.Generic;

namespace Assets.Exercise_4.Scripts
{
    public class AllBalloonsBurst : GameEndCondition
    {
        public AllBalloonsBurst(List<Balloon> balloons) : base(balloons)
        {
        }

        public override bool IsFail(BalloonColors burstBalloonColor)
        {
            return false;
        }

        public override bool IsWin()
        {
            return Balloons.Count == 0;
        }
    }
}