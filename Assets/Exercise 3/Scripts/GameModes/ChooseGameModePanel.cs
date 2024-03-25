using Exercise_3.Scripts.Loader;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Exercise_3.Scripts.GameModes
{
    public class ChooseGameModePanel : MonoBehaviour
    {
        [SerializeField] private Button _oneColorModeButton;
        [SerializeField] private Button _allColorModeButton;

        private SceneLoadMediator _sceneLoader;

        [Inject]
        private void Construct(SceneLoadMediator sceneLoadMediator)
        {
            _sceneLoader = sceneLoadMediator;
        }

        private void OnEnable()
        {
            _oneColorModeButton.onClick.AddListener(OnOneColorModeButtonClicked);
            _allColorModeButton.onClick.AddListener(OnAllColorModeButtonClicked);
        }

        private void OnDisable()
        {
            _oneColorModeButton.onClick.RemoveListener(OnOneColorModeButtonClicked);
            _allColorModeButton.onClick.RemoveListener(OnAllColorModeButtonClicked);
        }

        private void OnOneColorModeButtonClicked()
        {
            _sceneLoader.GoToGameplayLevel(new LevelLoadingData(GameMode.OneColor));
        }

        private void OnAllColorModeButtonClicked()
        {
            _sceneLoader.GoToGameplayLevel(new LevelLoadingData(GameMode.AllColors));
        }
    }
}
