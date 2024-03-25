using Zenject;

namespace Exercise_3.Scripts.Loader
{
    public class SceneLoadMediator 
    {
        private ISimpleSceneLoader _simpleSceneLoader;
        private ILevelLoader _levelLoader;

        [Inject]
        private void Construct(ISimpleSceneLoader simpleSceneLoader, ILevelLoader levelLoader)
        {
            _simpleSceneLoader = simpleSceneLoader;
            _levelLoader = levelLoader;
        }

        public void GoToGameplayLevel(LevelLoadingData levelLoadingData)
            => _levelLoader.Load(levelLoadingData);

        public void GoToMainMenu()
            => _simpleSceneLoader.Load(SceneID.MainMenu);
    }
}
