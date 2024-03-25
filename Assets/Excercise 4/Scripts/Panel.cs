using Assets.Visitor;
using UnityEngine;
using UnityEngine.UI;

namespace Excercise_4.Scripts
{
    public class Panel : MonoBehaviour
    {
        [SerializeField] private Button _killEnemyButton;
        [SerializeField] private Button _startWorkButton;
        [SerializeField] private Spawner _spawner;

        private void OnEnable()
        {
            _killEnemyButton.onClick.AddListener(OnKillEnemyButtonClicked);
            _startWorkButton.onClick.AddListener(OnStartWorkButtonClicked);
        }

        private void OnDisable()
        {
            _killEnemyButton.onClick.RemoveListener(OnKillEnemyButtonClicked);
            _startWorkButton.onClick.RemoveListener(OnStartWorkButtonClicked);
        }

        private void OnKillEnemyButtonClicked()
        {
            _spawner.GetRandomSpawnedEnemy()?.Kill();
        }

        private void OnStartWorkButtonClicked()
        {
            _spawner.StartWork();
        }
    }
}