using System.Collections.Generic;
using Assets.Exercise_4.Scripts;
using UnityEngine;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private Level _level;
    [SerializeField] private BalloonsSpawner _balloonsSpawner;
    [SerializeField] private LevelEndChanger _levelEndChanger;
    [SerializeField] private BalloonClicker _balloonClicker;

    private GameEndCondition _endCondition;

    private void Start()
    {
        _balloonClicker.enabled = false;
        _balloonsSpawner.Init();
        List<Balloon> balloons = _balloonsSpawner.Spawn();
        _levelEndChanger.Init(balloons);
        _levelEndChanger.gameObject.SetActive(true);
    }

    private void OnEnable()
    {
        _levelEndChanger.LevelEndChanged += OnLevelEndChanged;
    }

    private void OnDisable()
    {
        _levelEndChanger.LevelEndChanged -= OnLevelEndChanged;
    }

    private void OnDestroy()
    {
        _endCondition.Dispose();
    }

    private void OnLevelEndChanged(GameEndCondition gameEndCondition)
    {
        _endCondition = gameEndCondition;
        _level.Init(gameEndCondition, _balloonClicker);
        _balloonClicker.enabled = true;
    }
}
