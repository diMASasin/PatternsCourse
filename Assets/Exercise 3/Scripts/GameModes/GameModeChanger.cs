using Exercise_3.Scripts.GameModes.GameEndConditions;
using Exercise_3.Scripts.Loader;
using Plugins.Zenject.Source.Main;
using UnityEngine;
using Zenject;

namespace Exercise_3.Scripts.GameModes
{
    public class GameModeChanger
    {
        private DiContainer _container;

        [Inject]
        public void Construct(LevelLoadingData levelLoadingData, DiContainer container)
        {
            _container = container;

            ChooseGameMode(levelLoadingData.GameMode);
            Debug.Log(levelLoadingData.GameMode);
        }

        private void ChooseGameMode(GameMode loadingDataGameMode)
        {
            switch (loadingDataGameMode)
            {
                case GameMode.OneColor:
                    SetSameColorBalloonsCondition();
                    break;

                case GameMode.AllColors:
                    SetAllBalloonsCondition();
                    break;
            }
        }

        public void SetAllBalloonsCondition()
        {
            _container.BindInterfacesAndSelfTo<AllBalloonsBurst>().AsSingle();
        }

        public void SetSameColorBalloonsCondition()
        {
            _container.BindInterfacesAndSelfTo<SameColorBalloonsBurst>().AsSingle();
        }
    }
}