using System;
using System.Collections.Generic;
using System.Linq;
using Exercise_3.Scripts.Balloons;
using Exercise_3.Scripts.Configs;
using Zenject;

namespace Exercise_3.Scripts.GameModes.GameEndConditions
{
    public class SameColorBalloonsBurst : IGameEndCondition
    {
        private BalloonSpawnConfig _config;

        [Inject]
        private void Construct(BalloonSpawnConfig config)
        {
            _config = config;
        }

        public bool IsFail(List<Balloon> balloons)
        {
            int colorsNumber = Enum.GetValues(typeof(BalloonColors)).Length;
            int burstColorNumber = 0;

            for (int i = 0; i < colorsNumber; i++)
            {
                BalloonColors configColor = _config.BallonColorConfigs[i].BalloonColor;
                int configAmount = _config.BallonColorConfigs[i].Amount;

                if (balloons.Count(balloon => balloon.Color == configColor) < configAmount)
                    burstColorNumber++;
            }

            return burstColorNumber >= 2;
        }

        public bool IsWin(List<Balloon> balloons)
        {
            return balloons.Exists(balloon => balloon.Color == BalloonColors.Red) == false ||
                   balloons.Exists(balloon => balloon.Color == BalloonColors.Green) == false ||
                   balloons.Exists(balloon => balloon.Color == BalloonColors.White) == false;
        }
    }
}