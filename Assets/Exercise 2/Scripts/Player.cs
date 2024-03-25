using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _health = 100;
    [SerializeField] private int _expirienceToLevelUp = 100;
    [SerializeField] private int _initialExpirience = 0;
    [SerializeField] private int _initialLevel = 0;

    private int _expirience = 0;
    private int _level = 0;

    public event Action<int, int> HealthChanged;
    public event Action<int, int> ExpirienceChanged;
    public event Action Died;
    public event Action<int> LevelChanged;

    private void Start()
    {
        Reset();
    }

    public void Reset()
    {
        _health = _maxHealth;
        _expirience = _initialExpirience;
        _level = _initialLevel;

        HealthChanged?.Invoke(_health, _maxHealth);
        LevelChanged?.Invoke(_level);
        ExpirienceChanged?.Invoke(_expirience, _expirienceToLevelUp);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health, _maxHealth);

        if (_health <= 0)
            Died?.Invoke();
    }

    public void GetExperience(int expirience)
    {
        _expirience += expirience;

        if (_expirience >= _expirienceToLevelUp)
        {
            _level++;
            LevelChanged?.Invoke(_level);
            _expirience = 0;
        }

        ExpirienceChanged?.Invoke(_expirience, _expirienceToLevelUp);
    }
}
