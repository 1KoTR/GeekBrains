using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class ExecuteSumOfVectorsJob : MonoBehaviour
{
    [SerializeField]
    private Vector3[] _startPositions;
    [SerializeField]
    private Vector3[] _startVelocities;

    private NativeArray<Vector3> _positions;
    private NativeArray<Vector3> _velocities;

    private NativeArray<Vector3> _finalPositions;

    private JobHandle _jobHandle;

    private async void Start()
    {
        int pLen = _startPositions.Length, vLen = _startVelocities.Length;
        if (pLen != vLen)
            throw new Exception("\"Start Positions\" length and \"Start Velocities\" length must be equal");

        _positions = new NativeArray<Vector3>(pLen, Allocator.TempJob);
        for (int i = 0, length = pLen; i < length; i++)
            _positions[i] = _startPositions[i];

        _velocities = new NativeArray<Vector3>(vLen, Allocator.TempJob);
        for (int i = 0, length = vLen; i < length; i++)
            _velocities[i] = _startVelocities[i];

        _finalPositions = new NativeArray<Vector3>(pLen, Allocator.TempJob);

        var job = new SumOfVectorsJob();
        job.Positions = _positions;
        job.Velocities = _velocities;
        job.FinalPositions = _finalPositions;

        _jobHandle = job.Schedule(pLen, 0);
        _jobHandle.Complete();

        await PrintFinalPositions();

        _positions.Dispose();
        _velocities.Dispose();
        _finalPositions.Dispose();
    }

    private async Task PrintFinalPositions()
    {
        while (!_jobHandle.IsCompleted)
            await Task.Yield();

        foreach (var vector in _finalPositions)
            print(vector);
    }
}
