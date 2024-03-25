using System.Collections.Generic;
using Exercise_3.Scripts.Balloons;

namespace Exercise_3.Scripts.GameModes.GameEndConditions
{
    public class AllBalloonsBurst : IGameEndCondition
    {
        public bool IsFail(List<Balloon> balloons)
        {
            return false;
        }

        public bool IsWin(List<Balloon> balloons)
        {
            return balloons.Count == 0;
        }
    }
}