using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Jobs;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed;
    [SerializeField, Range(0, 100000)] 
    private int _entitiesNumber;
    [SerializeField]
    private GameObject _entityPrefab;
 
    private TransformAccessArray _transformAccessArray;

    private void Start()
    {
        var transforms = new Transform[_entitiesNumber];
        for (int i = 0; i < _entitiesNumber; i++)
            transforms[i] = Instantiate(_entityPrefab).transform;
        _transformAccessArray = new TransformAccessArray(transforms);
    }

    private void Update()
    {
        var rotateJob = new RotateJob()
        {
            RotationSpeed = _rotationSpeed,
            DeltaTime = Time.deltaTime
        };
        var handle = rotateJob.Schedule(_transformAccessArray);
        handle.Complete();
    }

    private void OnDestroy()
    {
        _transformAccessArray.Dispose();
    }
}
