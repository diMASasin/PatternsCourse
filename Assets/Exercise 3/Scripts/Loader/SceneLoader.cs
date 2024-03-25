using System;

namespace Exercise_3.Scripts.Loader
{
    public class SceneLoader : ISimpleSceneLoader, ILevelLoader
    {
        private ZenjectSceneLoaderWrapper _zenjectSceneLoader;

        public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoader)
        {
            _zenjectSceneLoader = zenjectSceneLoader;
        }

        public void Load(LevelLoadingData levelLoadingData)
        {
            _zenjectSceneLoader.Load(container =>
            {
                container.BindInstance(levelLoadingData).NonLazy();
            }, (int)SceneID.GameplayLevel);
        }

        public void Load(SceneID sceneID)
        {
            if (sceneID == SceneID.GameplayLevel)
                throw new ArgumentException($"{SceneID.GameplayLevel} cannot be started without configuraton, use ILevelLoader");

            _zenjectSceneLoader.Load(null, (int)sceneID);
        }
    }
}
