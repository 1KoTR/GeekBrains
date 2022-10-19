using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField, Range(0, 1)]
    private float _minColorValue; 
    [SerializeField, Range(0, 1)]
    private float _maxColorValue;

    [SerializeField, Range(0, 1000)]
    private float _maxSpawnDistance;

    private MeshRenderer _meshRenderer;

    private Vector3 RandomPosition => Random.insideUnitSphere * _maxSpawnDistance;
    private Color RandomColor => new Color(RandomValueForColor, RandomValueForColor, RandomValueForColor);
    private float RandomValueForColor => Random.Range(_minColorValue, _maxColorValue);

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        transform.position = RandomPosition;
        _meshRenderer.material.color = RandomColor;
    }
}
