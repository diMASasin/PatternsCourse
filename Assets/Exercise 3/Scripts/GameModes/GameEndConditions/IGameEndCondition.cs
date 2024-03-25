using System.Collections.Generic;
using Exercise_3.Scripts.Balloons;

namespace Exercise_3.Scripts.GameModes.GameEndConditions
{
    public interface IGameEndCondition
    {
        bool IsFail(List<Balloon> balloons);
        bool IsWin(List<Balloon> balloons);
    }
}