using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    private Unit _unit;
    private Slider _healthBar;

    private void Awake()
    {
        _unit = GetComponentInParent<Unit>();
        _healthBar = GetComponentInChildren<Slider>();
    }

    private void OnEnable()
    {
        _unit.OnHealthChanged += ChangeHealthBarValue;
    }
    private void OnDisable()
    {
        _unit.OnHealthChanged -= ChangeHealthBarValue;
    }

    private void ChangeHealthBarValue(int newValue)
    {
        _healthBar.value = newValue;
    }
}
