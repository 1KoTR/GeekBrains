using System;
using System.Collections;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public Action<int> OnHealthChanged;

    [SerializeField] private int _health = 50;
    [SerializeField] private int _maxHealth = 100;

    [SerializeField] private int _healthIncrement = 5;
    [SerializeField] private float _healingTickInSeconds = .5f;
    [SerializeField] private float _healingDurationInSeconds = 3;

    private bool _isHealing = false;

    private void Start()
    {
        OnHealthChanged?.Invoke(_health);
    }

    public void ReceiveHealing()
    {
        if (_isHealing)
            return;

        _isHealing = true;
        StartCoroutine(HealingRoutine());
    }

    private IEnumerator HealingRoutine()
    {
        var routine = StartCoroutine(StopHealingRoutine());
        while (_isHealing)
        {
            yield return new WaitForSeconds(_healingTickInSeconds);
            IncreaseHP();

            if (_health == _maxHealth)
            {
                StopCoroutine(routine);
                StopHealing();
                break;
            }
        }
    }
    private IEnumerator StopHealingRoutine()
    {
        yield return new WaitForSeconds(_healingDurationInSeconds);
        StopHealing();
    }

    private void StopHealing()
    {
        _isHealing = false;
    }

    private void IncreaseHP()
    {
        var hp = _health + _healthIncrement;
        _health = hp > _maxHealth ? _maxHealth : hp;

        OnHealthChanged?.Invoke(_health);
    }
}
