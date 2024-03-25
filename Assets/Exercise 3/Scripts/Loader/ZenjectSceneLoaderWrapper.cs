using System;
using Plugins.Zenject.Source.Main;
using Plugins.Zenject.Source.Util;
using UnityEngine.SceneManagement;

namespace Exercise_3.Scripts.Loader
{
    public class ZenjectSceneLoaderWrapper 
    {
        private readonly ZenjectSceneLoader _zenjectSceneLoader;

        public ZenjectSceneLoaderWrapper(ZenjectSceneLoader zenjectSceneLoader)
            => _zenjectSceneLoader = zenjectSceneLoader;

        public void Load(Action<DiContainer> action, int sceneID)
            => _zenjectSceneLoader.LoadScene(sceneID, LoadSceneMode.Single, container => action?.Invoke(container));
    }
}
